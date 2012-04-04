 

using System.Runtime.Serialization;
using System.ServiceModel;
		// Services
namespace ADMDemoCompleteContract {
		    [ServiceContract]
    public interface IADMCompletedDemoService
    {

		        [OperationContract]
        double TestiSummaaLuvutYhteen(int Kokonaisluku, double Liukuluku);
		
		        [OperationContract]
        decimal LaskeVeroprosentti(VerotettavaTulomaara lahtoarvot);
		
		        [OperationContract]
        string GetData(int value, int value2);
		
		        [OperationContract]
        string SayHi(MyComposite customParam);
		
		    }
		
		    [DataContract]
    public class MyComposite
    {
		        string _Message = "Hi!";

        [DataMember]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
			}
		    [DataContract]
    public class VerotettavaTulomaara
    {
		        Palkkatulo _PalkkatuloArvo;

        [DataMember]
        public Palkkatulo PalkkatuloArvo
        {
            get { return _PalkkatuloArvo; }
            set { _PalkkatuloArvo = value; }
        }
		        decimal _Paaomatulo;

        [DataMember]
        public decimal Paaomatulo
        {
            get { return _Paaomatulo; }
            set { _Paaomatulo = value; }
        }
			}
		    [DataContract]
    public class Palkkatulo
    {
		        decimal _SuomestaEuroja;

        [DataMember]
        public decimal SuomestaEuroja
        {
            get { return _SuomestaEuroja; }
            set { _SuomestaEuroja = value; }
        }
		        decimal _RuotsistaEuroja;

        [DataMember]
        public decimal RuotsistaEuroja
        {
            get { return _RuotsistaEuroja; }
            set { _RuotsistaEuroja = value; }
        }
			}
		}
		