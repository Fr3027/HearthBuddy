﻿namespace ns25
{
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    internal class Class248<T, U> : MonoClass where T: struct where U: struct
    {
        internal Class248(IntPtr address) : base(TritonHs.MainAssemblyDir + @"\mscorlib.dll", "System.Collections.Generic", "Dictionary<" + typeof(T).FullName + ", " + typeof(U).FullName + ">")
        {
            base.Address = address;
            base.UInt32_0 = MonoClass.Class272_0.method_10(address, true);
        }

        private Class257<T, U> method_24()
        {
            return base.method_14<Class257<T, U>>(Class271.string_0, Array.Empty<object>());
        }

        public Dictionary<T, U> method_25()
        {
            Dictionary<T, U> dictionary = new Dictionary<T, U>();
            Class257<T, U> class2 = this.method_24();
            while (class2.method_26())
            {
                dictionary.Add(class2.Prop_0, class2.Prop_1);
            }
            class2.method_24();
            return dictionary;
        }

        public int Int32_0
        {
            get
            {
                return base.method_11<int>("get_Count", Array.Empty<object>());
            }
        }
    }
}

