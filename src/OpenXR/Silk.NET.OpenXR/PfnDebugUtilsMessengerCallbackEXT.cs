﻿using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenXR
{
    public readonly unsafe struct PfnDebugUtilsMessengerCallbackEXT
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
            DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> Handle =>
            (delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32>) _handle;

        public PfnDebugUtilsMessengerCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> ptr
        ) => _handle = ptr;

        public static implicit operator nint(PfnDebugUtilsMessengerCallbackEXT pfn) => (nint) pfn.Handle;

        public PfnDebugUtilsMessengerCallbackEXT(DebugUtilsMessengerCallbackFunctionEXT func) => _handle =
            (delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32>) SilkMarshal.DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT,
            DebugUtilsMessageTypeFlagsEXT, DebugUtilsMessengerCallbackDataEXT*, void*, Bool32>
            (PfnDebugUtilsMessengerCallbackEXT pfn) => pfn.Handle;

        public static implicit operator PfnDebugUtilsMessengerCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> func
        ) => new(func);

        public static implicit operator PfnDebugUtilsMessengerCallbackEXT
            (DebugUtilsMessengerCallbackFunctionEXT func) => new(func);

        public static explicit operator DebugUtilsMessengerCallbackFunctionEXT
            (PfnDebugUtilsMessengerCallbackEXT pfn) => SilkMarshal.PtrToDelegate<DebugUtilsMessengerCallbackFunctionEXT>
            ((nint) pfn.Handle);
    }
}