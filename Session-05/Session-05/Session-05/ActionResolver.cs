using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {   
            Logger = new MessageLogger();

        }

        public ActionResponse Execute(ActionRequest request )
        {
            ActionResponse actionResponse = new ActionResponse();
            switch ( request.Action)
            {
                case ActionEnum.Convert:
                    actionResponse = new ActionResponse
                    {
                        RequestID = request.RequestID,
                        Output = Convert(request.Input)
                    };
                    Logger.Write(new Message
                    {
                        MessageText = "Successfully executed action"
                    });
                    
                    break;
                case ActionEnum.Uppercase:
                    actionResponse = new ActionResponse
                    {
                        RequestID = request.RequestID,
                        Output = Uppercase(request.Input)
                    };
                    Logger.Write(new Message
                    {
                        MessageText = "Successfully executed action"
                    });
                    break;
                case ActionEnum.Reverse:
                    actionResponse = new ActionResponse
                    {
                        RequestID = request.RequestID,
                        Output = Reverse(request.Input)
                    };
                    Logger.Write(new Message
                    {
                        MessageText = "Successfully executed action"
                    });
                    break;
                default:
                    Logger.Write(new Message
                    {
                        MessageText = "Try again"
                    });
                    break;

            }
            return actionResponse;
        }

        private string Convert(string data)
        {   

            string binary = string.Empty;
            int rem;

            try
            {
                if (!int.TryParse(data, out int num ))
                {
                    Logger.Write(new Message
                    {
                        MessageText = "Invalid Value - This is not a numeric value"
                    });
                }
                else
                {
                    while (num > 0)
                    {
                        rem = num % 2;
                        num /= 2;
                        binary += rem.ToString();
                    }
                }
            }catch (Exception ex)
            {
                Logger.Write(new Message
                {
                    MessageText = ex.Message
                });
            }
            return binary;

        }
        
        private string Uppercase(string phrase)
        {
            
            string answer = string.Empty;
            var words = phrase.Split(' ');
            string longestWord = words[0];
            if (!decimal.TryParse(phrase, out decimal result))
            {
                if (words.Length < 2)
                {
                    Logger.Write(new Message
                    {
                        MessageText = "There are less than two words"
                    });
                }
                else
                {

                    for (int i = 1; i < words.Length; i++)
                    {
                        if (words[i].Length > words[i - 1].Length)
                        {
                            longestWord = words[i];
                        }

                    }
                }
            }
            else
            {
                Logger.Write(new Message
                {
                    MessageText = "Invalid input"
                });
            }
            return longestWord.ToUpper();
        }

        private string Reverse(string data)
        {   
            string reversedData = string.Empty;
            char[] charArray = data.ToCharArray();
            if (!int.TryParse(data, out int result)){
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    reversedData += charArray[i];
                }
                return reversedData;
            }
            else
            {
                Logger.Write(new Message
                {
                    MessageText = "Invalid input"
                });
            }
            return String.Empty;

        }

        


    }
}
