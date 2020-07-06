﻿using BlockIoLib.Examples;
using NBitcoin;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace BlockIoLib
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * TESTS
             */

            string api_key = "";
            string pin = "";

            Basic example = new Basic(api_key, pin);
            example.RunBasicExample();
            // Withdraw

            //BlockIo test = new BlockIo(api_key, pin);
            //
            //Console.WriteLine(test.WithdrawFromAddresses("{amounts: 0.1, from_addresses:['2N8pEWg9ZPyxa2yioZWDYAzNFyTnYp6TkHF'], to_addresses:['my9gXk65EzZUL962MSJadPXJFmJzPDc1WT']}").Data);

            // Sweep

            //BlockIo test = new BlockIo(api_key, pin);
            //string wif = "cUhedoiwPkprm99qfUKzixsrpN3w6wT2XrrMjqo3Yh1tHz8ykVKc";
            //string from_address = "my9gXk65EzZUL962MSJadPXJFmJzPDc1WT";
            //string sweepArgs = "{ private_key: '" + wif + "', to_address: '2N8pEWg9ZPyxa2yioZWDYAzNFyTnYp6TkHF'}";
            
            //Console.WriteLine(test.SweepFromAddress(sweepArgs).Data);

        }
    }
}
