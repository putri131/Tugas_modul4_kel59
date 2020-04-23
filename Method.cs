using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Modul4_kel59
{
    class Method
    {
        static String menu()
        {
            return "********Menu ATM Bank Kita********* \n 1. Cek Saldo \n 2. Tarik Tunai \n 3. Setor Tunai \n 4. Ubah Pin \n 5. Keluar \n ===============================================";
        }
        public void ATM()
        {
                int saldo = 1000000, setoran, penarikan;
                int pilihan, pin, pin2;
                string Ulang = "";

            Console.WriteLine("Masukkan Pin Anda ");
            pin = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Clear();

            do
                {
                Console.WriteLine(menu());

                Console.WriteLine("Masukkan Pilihan Anda: ");
                    pilihan = int.Parse(Console.ReadLine());
                Console.Clear();

                if (pilihan <= 5)
                    {
                        switch (pilihan)
                        {
                            case 1:
                                Console.WriteLine("Saldo Anda adalah: Rp.{0}", saldo);
                                Console.WriteLine(" ");
                                break;

                            case 2:
                                Console.WriteLine("Masukkan Jumlah Yang ingin Diambil: ");
                                penarikan = int.Parse(Console.ReadLine());
                                if (penarikan % 50000 != 0)
                                {
                                    Console.WriteLine("Masukkan Jumlah dengan Kelipatan 50000");
                                }
                                else if (penarikan > saldo)
                                {
                                    Console.WriteLine("Saldo Tidak Cukup");
                                }
                                else
                                {
                                    saldo = saldo - penarikan;
                                    Console.WriteLine("Silakan Ambil Uang Anda");
                                    Console.WriteLine("Sisa Saldo Anda adalah Rp.{0}", saldo);
                                }
                                Console.WriteLine(" ");
                                break;
                            case 3:
                                Console.WriteLine("Masukkan Jumlah Setoran");
                                setoran = int.Parse(Console.ReadLine());
                                saldo = saldo + setoran;
                                Console.WriteLine("Saldo Anda Sekarang adalah Rp.{0}", saldo);
                                Console.WriteLine(" ");
                                break;
                            case 4:
                                Console.WriteLine("Mengubah Pin");
                                Console.WriteLine("Masukkan Pin Sebelumnya");
                                int pin_aw = int.Parse(Console.ReadLine());
                                if (pin_aw == pin)
                                {
                                    Console.WriteLine("Masukkan Pin Baru");
                                    pin2 = int.Parse(Console.ReadLine());
                                    pin = pin2;
                                    Console.WriteLine("Pin Anda Telah Berubah \n Pin Baru Anda adalah {0}", pin2);
                                }
                                else
                                {
                                    Console.WriteLine("Pin yang Anda Masukkan Salah");
                                    Console.WriteLine("Masukkan Pin yang Benar");
                                }
                                Console.WriteLine(" ");
                                break;
                            case 5:
                                Console.WriteLine("Transaksi Selesai");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Pilihan Tidak Ada di Menu");
                        Console.WriteLine("Mohon Pilih Menu yang Tersedia");
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine("Terima Kasih Telah Menggunakan ATM Bank Kita :)");
                    Console.WriteLine("Apakah Anda Ingin Melakukan Transaksi Lagi? [Y/T]");
                    Ulang = Console.ReadLine();
                    Console.WriteLine(" ");
                    Console.Clear();
                }
                while (Ulang.ToLower() == "y");
            }
        }
    }



