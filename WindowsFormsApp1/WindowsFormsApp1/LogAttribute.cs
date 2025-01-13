using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodDecorator.Fody.Interfaces;

namespace WindowsFormsApp1
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Assembly)]
    public class LogAttritas : Attribute, IMethodDecorator
    {
        private DateTime _startTime;

        // 메서드 호출 전 실행
        public void Init(object instance, System.Reflection.MethodBase method, object[] args)
        {
            Console.WriteLine($"메서드 {method.Name} 호출 시작");
            _startTime = DateTime.Now;
        }

        // 메서드 실행 후 실행
        public void OnExit()
        {
            var duration = DateTime.Now - _startTime;
            Console.WriteLine($"메서드 종료. 실행 시간: {duration.TotalMilliseconds}ms");
        }

        // 예외 발생 시 실행
        public void OnException(Exception exception)
        {
            Console.WriteLine($"예외 발생: {exception.Message}");
        }

        public void OnEntry()
        {

        }
    }
}
