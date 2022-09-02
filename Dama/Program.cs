﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dama
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Kart> setlist = new List<Kart>();
            List<Kart> humanList = new List<Kart>();
            List<Kart> CompList = new List<Kart>();
            List<Kart> GameCartList = new List<Kart>();
            List<Kart> GameHumanList = new List<Kart>();
            List<Kart> GameComputerList = new List<Kart>();
            int sayac = 0, HumanPuan = 0, ComputerPuan = 0,idCounter=0;
            var rnd = new Random();
            List<Kart> CreateCartList(string name)
            {
                setlist.Add(new Kart() {Id=idCounter, SetNo = "A", SetType = name });
                idCounter++;
                for (int i = 2; i < 11; i++)
                {
                    setlist.Add(new Kart() {Id=idCounter, SetNo = i.ToString(), SetType = name });
                    idCounter++;
                }
                setlist.Add(new Kart() {Id=idCounter, SetNo = "J", SetType = name });
                idCounter++;
                setlist.Add(new Kart() { Id = idCounter, SetNo = "S", SetType = name });
                idCounter++;
                setlist.Add(new Kart() { Id = idCounter, SetNo = "K", SetType = name });
                return setlist;
            }

            void CreateNewCartList()
            {
                var setlist1 = new List<string>();
                setlist1.Add("Ku");
                setlist1.Add("Ka");
                setlist1.Add("M");
                setlist1.Add("S");

                for (int i = 0; i < setlist1.Count; i++)
                {
                    CreateCartList(setlist1[i]);
                }


            }
            foreach (var item in setlist)
            {
                sayac++;
                Console.Write(item.KartName + " ");
                if (sayac == 13)
                {
                    Console.WriteLine();
                    sayac = 0;

                }


            }
            void MixDeste()
            {

                var mixSet = new List<Kart>();

                for (int i = 0; i < 52; i++)
                {
                    var rnd = new Random();
                    int desteItem = rnd.Next(0, 52);
                    if (desteItem < setlist.Count)
                    {
                        mixSet.Add(setlist[desteItem]);
                        RemoveItemtoDeste(desteItem);
                    }
                    else
                    {
                        i--;
                    }

                }

                setlist = mixSet;

            }
            Kart GetComputerKart(string kart)
            {
                var comDeste = CompList.Count;
                if (comDeste == 0)
                {
                    return null;
                }
                var isExist = CompList.Where(x => x.SetNo == kart).FirstOrDefault();
                if (isExist != null)
                {
                    var kk = CompList.Where(x => x.SetNo == kart).FirstOrDefault();
                    CompList.Remove(kk);
                    return kk;
                }
                var ss = CompList[0];
                CompList.Remove(ss);
                return ss;

            }

            Kart getHumanKart(string kart)
            {
                var k = humanList.Where(x => x.SetNo == kart).FirstOrDefault();
                humanList.Remove(k);
                return k;
            }

            CreateNewCartList();
            void CreateDeste()
            {
                int desteSayac = 0;
                int desteSon = setlist.Count - 4 == 0|| setlist.Count - 4 ==- 4 ? 2 : 4;
                //Human list
                for (int i = 0; i < desteSon; i++)
                {
                    humanList.Add(setlist[desteSayac]);
                    RemoveItemtoDeste(desteSayac);

                }
                for (int i = 0; i < desteSon; i++)
                {
                    CompList.Add(setlist[desteSayac]);
                    RemoveItemtoDeste(desteSayac);
                }

            }

            void RemoveItemtoDeste(int index)
            {
                setlist.RemoveAt(index);
            }
            void WriteDeste()
            {
                Console.WriteLine();
                Console.Write("Deste  :");
                foreach (var item in setlist)
                {
                    Console.Write(item.KartName + " ");

                }
                Console.WriteLine();
                Console.Write("Human Deste  :");

                foreach (var item in humanList)
                {
                    Console.Write(item.KartName + " ");

                }
                Console.WriteLine();
                Console.Write("Computer Deste  :");

                foreach (var item in CompList)
                {
                    Console.Write(item.KartName + " ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }

            void WriteGameCartList()
            {
                Console.WriteLine();
                Console.Write("Oyun Deste  :");

                foreach (var item in GameCartList)
                {
                    Console.Write(item.KartName + " ");
                }
                Console.WriteLine();
            }
            bool IsKartJ(string kart)
            {
                return kart == "J";
            }

            void WinnerHuman(string kart)
            {
                Console.WriteLine("İnsan Kazandı :" +kart);
                HumanPuan += 10;
                foreach (var item in GameCartList)
                {
                    GameHumanList.Add(item);
                }
                GameCartList = new List<Kart>();
            }
            void WinnerComputer(string kart)
            {
                ComputerPuan += 10;
                Console.WriteLine("Bilgisayar Kazandı: " +kart);
                foreach (var item in GameCartList)
                {

                    GameComputerList.Add(item);

                }
                GameCartList = new List<Kart>();

            }
            StartGame();

            void StartGame()
            {
                MixDeste();
                int tt = -1;

                do
                {
                    Console.WriteLine("Hoşgeldiniz");
                    Console.WriteLine("0-->Oyundan Çık");
                    Console.WriteLine("1-->Oyuna Başla");
                    Console.WriteLine("2-->Kart Karıştır");
                    Console.Write("Bir Secenek Seç !!  :");
                    tt = Convert.ToInt32(Console.ReadLine());

                    if (tt == 1)
                    {

                        CreateDeste();
                        WriteDeste();

                        while (tt != 0)
                        {
                            if (humanList.Count == 0)
                            {
                                Console.WriteLine("Deste bitti !! Yeni Deste ver ");
                                Console.WriteLine("Deste Verilsin mi ?");
                                var verilsin = Convert.ToInt32(Console.ReadLine());
                                if (verilsin == 1)
                                {
                                    CreateDeste();
                                    WriteDeste();
                                    WriteGameCartList();
                                }
                            }

                            Console.WriteLine("Bir kart At");
                            var ss = Console.ReadLine().ToUpper();
                            var kart = getHumanKart(ss);

                            if (GameCartList.Count > 0)
                            {
                                if (IsKartJ(kart.SetNo))
                                    WinnerHuman(kart.KartName);
                            }

                            else if (GameCartList.Count != 0)
                            {

                                var sonKart = GameCartList[GameCartList.Count - 1];

                                if (kart.SetNo == sonKart.SetNo)
                                {
                                    WinnerHuman(sonKart.KartName);
                                }
                                else
                                {
                                    GameCartList.Add(kart);

                                }
                            }
                            else
                            {
                                GameCartList.Add(kart);

                            }

                            var k = GetComputerKart(kart.SetNo);

                            if (GameCartList.Count > 0)
                            {
                                if (IsKartJ(k.SetNo))
                                    WinnerComputer(k.KartName);
                            }

                            if (GameCartList.Count != 0)
                            {
                                if (k.SetNo == GameCartList[GameCartList.Count - 1].SetNo)
                                {
                                    WinnerComputer(k.KartName);
                                }
                                else
                                {
                                    GameCartList.Add(k);
                                }
                            }
                            else
                            {
                                GameCartList.Add(k);
                            }

                            Console.Write("Human List  :");
                            foreach (var item in humanList)
                            {
                                Console.Write(item.KartName + " ");
                            }
                            Console.WriteLine();

                            Console.Write("Oyun Destesi :");
                            foreach (var item in GameCartList)
                            {
                                Console.Write(item.KartName + " ");
                            }

                            Console.WriteLine();

                        }


                    }
                    if (tt == 2)
                    {
                        MixDeste();
                    }
                    if (tt == 0)
                    {
                        tt = 0;
                    }
                } while (tt != 0);
            }


            Console.ReadKey();
        }
    }
}
