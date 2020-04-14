using AutoMapper;
using ProjectB;

namespace ProjectA
{
    public class Class1
    {
        public void DoStuff(IMapper mapper)
        {
            var cls2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Class2>("");
            var mapped = mapper.Map<Class1>(cls2);
        }
    }
}