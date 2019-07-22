using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Program
    {

        //异步方法
        public async Task<int> MethodA(DateTime bgtime, int i)
        {
            int r = await Task.Run(() =>
            {
                Console.WriteLine("异步方法{0}Task被执行", i);
                Thread.Sleep(100);
                return i * 2;
            });
            Console.WriteLine("异步方法{0}执行完毕，结果{1}", i, r);

            //if (i == 4)
            //{
            //    Console.WriteLine("用时{0}", (DateTime.Now - bgtime).TotalMilliseconds);
            //}
            return r;
        }
        //普通方法
        public int MethodB(DateTime bgtime, int i)
        {
            int r = Task.Run(() =>
            {
                Console.WriteLine("普通多线程方法{0}Task被执行", i);
                Thread.Sleep(100);
                return i * 2;
            }).Result;
            Console.WriteLine("普通方法{0}执行完毕，结果{1}", i, r);

            if (i == 4)
            {
                Console.WriteLine("用时{0}", (DateTime.Now - bgtime).TotalMilliseconds);
            }
            return r;
        }


        static void Main(string[] args)
        {

            Program p = new Program();



            DateTime pbgtime = DateTime.Now;
            //for (int i = 0; i < 5; i++)
            //{
            //   // p.MethodB(pbgtime, i);
            //    Console.WriteLine("普通方法{0}调用完成", i);
            //}



            NewMethodAsync(p);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            //while (Console.ReadKey().Key != ConsoleKey.Q)
            //    HttpGet();

            Console.Read();
        }

        private static async Task NewMethodAsync(Program p)
        {
            DateTime abgtime = DateTime.Now;
            for (int i = 0; i < 5; i++)
            {
                p.MethodA(abgtime, i);
                Console.WriteLine("异步方法{0}调用完成", i);
            }
        }

        private static async System.Threading.Tasks.Task HttpGet()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource(200);
            using (HttpClient client = new HttpClient())
            {
                // Call asynchronous network methods in a try/catch block to handle exceptions
                var bgtime = DateTime.Now;
                try
                {
                    Console.WriteLine("request start...........................");
                    HttpResponseMessage response = await client.GetAsync("http://www.baidu.com/", cancellation.Token);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    Console.WriteLine(responseBody);

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
                finally
                {
                    Console.WriteLine("request end ..............................");
                    Console.WriteLine($"cost time: { ((DateTime.Now - bgtime).TotalMilliseconds)}");
                }
            }
        }
    }
}
