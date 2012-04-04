﻿ 



using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using ADMDemoCompleteContract;

		
namespace ADMDemoCompleteClient
{
		    public class ADMCompletedDemoServiceClient
    {
		        

        public static double  TestiSummaaLuvutYhteen(int Kokonaisluku, double Liukuluku)
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:56071/ADMCompletedDemoService.svc");
            IADMCompletedDemoService service =
                new ChannelFactory< IADMCompletedDemoService >(basicHttpBinding, endpointAddress).CreateChannel();
            var serviceResponse = service.TestiSummaaLuvutYhteen(Kokonaisluku, Liukuluku);
            return serviceResponse;
        }
		
		
		        

        public static decimal  LaskeVeroprosentti(VerotettavaTulomaara lahtoarvot)
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:56071/ADMCompletedDemoService.svc");
            IADMCompletedDemoService service =
                new ChannelFactory< IADMCompletedDemoService >(basicHttpBinding, endpointAddress).CreateChannel();
            var serviceResponse = service.LaskeVeroprosentti(lahtoarvot);
            return serviceResponse;
        }
		
		
		        

        public static string  GetData(int value, int value2)
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:56071/ADMCompletedDemoService.svc");
            IADMCompletedDemoService service =
                new ChannelFactory< IADMCompletedDemoService >(basicHttpBinding, endpointAddress).CreateChannel();
            var serviceResponse = service.GetData(value, value2);
            return serviceResponse;
        }
		
		
		        

        public static string  SayHi(MyComposite customParam)
        {
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:56071/ADMCompletedDemoService.svc");
            IADMCompletedDemoService service =
                new ChannelFactory< IADMCompletedDemoService >(basicHttpBinding, endpointAddress).CreateChannel();
            var serviceResponse = service.SayHi(customParam);
            return serviceResponse;
        }
		
		
		    }
		}
		