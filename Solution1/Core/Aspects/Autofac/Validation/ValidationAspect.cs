﻿
using Castle.DynamicProxy;
using FluentValidation;
using System.Runtime.CompilerServices;

namespace Core
{
    public class ValidationAspect:MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType) 
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            _validatorType = validatorType;
        }


        //validation methodun başında yapılır.
        protected override void OnBefore(IInvocation invocation)
        {
            var validator=(IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities=invocation.Arguments.Where(t=> t.GetType()==entityType);
            foreach (var item in entities)
            {
                ValidationTool.Validate(validator, item);
            }
        }
    }
}
