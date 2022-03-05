﻿using System;
using System.Linq;
using DolphOutFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;

namespace DolphOutFramework.Core.Aspects.PostSharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;

        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entites = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entites)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}