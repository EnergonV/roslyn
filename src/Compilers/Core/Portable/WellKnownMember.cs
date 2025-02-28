﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    // Members of well known types
    internal enum WellKnownMember
    {
        System_Math__RoundDouble,
        System_Math__PowDoubleDouble,

        System_Array__get_Length,
        System_Array__Empty,

        System_Convert__ToBooleanDecimal,
        System_Convert__ToBooleanInt32,
        System_Convert__ToBooleanUInt32,
        System_Convert__ToBooleanInt64,
        System_Convert__ToBooleanUInt64,
        System_Convert__ToBooleanSingle,
        System_Convert__ToBooleanDouble,
        System_Convert__ToSByteDecimal,
        System_Convert__ToSByteDouble,
        System_Convert__ToSByteSingle,
        System_Convert__ToByteDecimal,
        System_Convert__ToByteDouble,
        System_Convert__ToByteSingle,
        System_Convert__ToInt16Decimal,
        System_Convert__ToInt16Double,
        System_Convert__ToInt16Single,
        System_Convert__ToUInt16Decimal,
        System_Convert__ToUInt16Double,
        System_Convert__ToUInt16Single,
        System_Convert__ToInt32Decimal,
        System_Convert__ToInt32Double,
        System_Convert__ToInt32Single,
        System_Convert__ToUInt32Decimal,
        System_Convert__ToUInt32Double,
        System_Convert__ToUInt32Single,
        System_Convert__ToInt64Decimal,
        System_Convert__ToInt64Double,
        System_Convert__ToInt64Single,
        System_Convert__ToUInt64Decimal,
        System_Convert__ToUInt64Double,
        System_Convert__ToUInt64Single,
        System_Convert__ToSingleDecimal,
        System_Convert__ToDoubleDecimal,

        System_CLSCompliantAttribute__ctor,
        System_FlagsAttribute__ctor,
        System_Guid__ctor,

        System_Type__GetTypeFromCLSID,
        System_Type__GetTypeFromHandle,
        System_Type__Missing,
        System_Type__op_Equality,

        System_Reflection_AssemblyKeyFileAttribute__ctor,
        System_Reflection_AssemblyKeyNameAttribute__ctor,

        System_Reflection_MethodBase__GetMethodFromHandle,
        System_Reflection_MethodBase__GetMethodFromHandle2,
        System_Reflection_MethodInfo__CreateDelegate,
        System_Delegate__CreateDelegate,
        System_Delegate__CreateDelegate4,
        System_Reflection_FieldInfo__GetFieldFromHandle,
        System_Reflection_FieldInfo__GetFieldFromHandle2,

        System_Reflection_Missing__Value,

        System_IEquatable_T__Equals,

        System_Collections_Generic_IEqualityComparer_T__Equals,

        System_Collections_Generic_EqualityComparer_T__Equals,
        System_Collections_Generic_EqualityComparer_T__GetHashCode,
        System_Collections_Generic_EqualityComparer_T__get_Default,

        System_AttributeUsageAttribute__ctor,
        System_AttributeUsageAttribute__AllowMultiple,
        System_AttributeUsageAttribute__Inherited,

        System_ParamArrayAttribute__ctor,
        System_STAThreadAttribute__ctor,

        System_Reflection_DefaultMemberAttribute__ctor,

        System_Diagnostics_Debugger__Break,
        System_Diagnostics_DebuggerDisplayAttribute__ctor,
        System_Diagnostics_DebuggerDisplayAttribute__Type,
        System_Diagnostics_DebuggerNonUserCodeAttribute__ctor,
        System_Diagnostics_DebuggerHiddenAttribute__ctor,
        System_Diagnostics_DebuggerBrowsableAttribute__ctor,
        System_Diagnostics_DebuggerStepThroughAttribute__ctor,
        System_Diagnostics_DebuggableAttribute__ctorDebuggingModes,
        System_Diagnostics_DebuggableAttribute_DebuggingModes__Default,
        System_Diagnostics_DebuggableAttribute_DebuggingModes__DisableOptimizations,
        System_Diagnostics_DebuggableAttribute_DebuggingModes__EnableEditAndContinue,
        System_Diagnostics_DebuggableAttribute_DebuggingModes__IgnoreSymbolStoreSequencePoints,

        System_Runtime_InteropServices_UnknownWrapper__ctor,
        System_Runtime_InteropServices_DispatchWrapper__ctor,
        System_Runtime_InteropServices_ClassInterfaceAttribute__ctorClassInterfaceType,
        System_Runtime_InteropServices_CoClassAttribute__ctor,
        System_Runtime_InteropServices_ComAwareEventInfo__ctor,
        System_Runtime_InteropServices_ComAwareEventInfo__AddEventHandler,
        System_Runtime_InteropServices_ComAwareEventInfo__RemoveEventHandler,
        System_Runtime_InteropServices_ComEventInterfaceAttribute__ctor,
        System_Runtime_InteropServices_ComSourceInterfacesAttribute__ctorString,
        System_Runtime_InteropServices_ComVisibleAttribute__ctor,
        System_Runtime_InteropServices_DispIdAttribute__ctor,
        System_Runtime_InteropServices_GuidAttribute__ctor,
        System_Runtime_InteropServices_InterfaceTypeAttribute__ctorComInterfaceType,
        System_Runtime_InteropServices_InterfaceTypeAttribute__ctorInt16,
        System_Runtime_InteropServices_Marshal__GetTypeFromCLSID,
        System_Runtime_InteropServices_TypeIdentifierAttribute__ctor,
        System_Runtime_InteropServices_TypeIdentifierAttribute__ctorStringString,
        System_Runtime_InteropServices_BestFitMappingAttribute__ctor,
        System_Runtime_InteropServices_DefaultParameterValueAttribute__ctor,
        System_Runtime_InteropServices_LCIDConversionAttribute__ctor,
        System_Runtime_InteropServices_UnmanagedFunctionPointerAttribute__ctor,

        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__AddEventHandler,
        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__GetOrCreateEventRegistrationTokenTable,
        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__InvocationList,
        System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__RemoveEventHandler,

        System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__AddEventHandler_T,
        System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__RemoveAllEventHandlers,
        System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__RemoveEventHandler_T,

        System_Runtime_CompilerServices_DateTimeConstantAttribute__ctor,
        System_Runtime_CompilerServices_DecimalConstantAttribute__ctor,
        System_Runtime_CompilerServices_DecimalConstantAttribute__ctorByteByteInt32Int32Int32,
        System_Runtime_CompilerServices_ExtensionAttribute__ctor,
        System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor,
        System_Runtime_CompilerServices_AccessedThroughPropertyAttribute__ctor,
        System_Runtime_CompilerServices_CompilationRelaxationsAttribute__ctorInt32,
        System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__ctor,
        System_Runtime_CompilerServices_RuntimeCompatibilityAttribute__WrapNonExceptionThrows,
        System_Runtime_CompilerServices_UnsafeValueTypeAttribute__ctor,
        System_Runtime_CompilerServices_FixedBufferAttribute__ctor,
        System_Runtime_CompilerServices_DynamicAttribute__ctor,
        System_Runtime_CompilerServices_DynamicAttribute__ctorTransformFlags,
        System_Runtime_CompilerServices_CallSite_T__Create,
        System_Runtime_CompilerServices_CallSite_T__Target,

        System_Runtime_CompilerServices_RuntimeHelpers__GetObjectValueObject,
        System_Runtime_CompilerServices_RuntimeHelpers__InitializeArrayArrayRuntimeFieldHandle,
        System_Runtime_CompilerServices_RuntimeHelpers__get_OffsetToStringData,
        System_Runtime_CompilerServices_RuntimeHelpers__GetSubArray_T,
        System_Runtime_CompilerServices_RuntimeHelpers__EnsureSufficientExecutionStack,

        System_Runtime_ExceptionServices_ExceptionDispatchInfo__Capture,
        System_Runtime_ExceptionServices_ExceptionDispatchInfo__Throw,

        System_Security_UnverifiableCodeAttribute__ctor,
        System_Security_Permissions_SecurityAction__RequestMinimum,
        System_Security_Permissions_SecurityPermissionAttribute__ctor,
        System_Security_Permissions_SecurityPermissionAttribute__SkipVerification,

        System_Activator__CreateInstance,
        System_Activator__CreateInstance_T,

        System_Threading_Interlocked__CompareExchange,
        System_Threading_Interlocked__CompareExchange_T,

        System_Threading_Monitor__Enter, //Monitor.Enter(object)
        System_Threading_Monitor__Enter2, //Monitor.Enter(object, bool&)
        System_Threading_Monitor__Exit,

        System_Threading_Thread__CurrentThread,
        System_Threading_Thread__ManagedThreadId,

        Microsoft_CSharp_RuntimeBinder_Binder__BinaryOperation,
        Microsoft_CSharp_RuntimeBinder_Binder__Convert,
        Microsoft_CSharp_RuntimeBinder_Binder__GetIndex,
        Microsoft_CSharp_RuntimeBinder_Binder__GetMember,
        Microsoft_CSharp_RuntimeBinder_Binder__Invoke,
        Microsoft_CSharp_RuntimeBinder_Binder__InvokeConstructor,
        Microsoft_CSharp_RuntimeBinder_Binder__InvokeMember,
        Microsoft_CSharp_RuntimeBinder_Binder__IsEvent,
        Microsoft_CSharp_RuntimeBinder_Binder__SetIndex,
        Microsoft_CSharp_RuntimeBinder_Binder__SetMember,
        Microsoft_CSharp_RuntimeBinder_Binder__UnaryOperation,
        Microsoft_CSharp_RuntimeBinder_CSharpArgumentInfo__Create,

        Microsoft_VisualBasic_CompilerServices_Conversions__ToDecimalBoolean,

        Microsoft_VisualBasic_CompilerServices_Conversions__ToBooleanString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToSByteString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToByteString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToShortString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToUShortString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToIntegerString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToUIntegerString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToLongString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToULongString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToSingleString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDoubleString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDecimalString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDateString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToCharString,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToCharArrayRankOneString,

        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringBoolean,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringInt32,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringByte,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringUInt32,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringInt64,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringUInt64,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringSingle,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringDouble,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringDecimal,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringDateTime,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringChar,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToStringObject,

        Microsoft_VisualBasic_CompilerServices_Conversions__ToBooleanObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToSByteObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToByteObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToShortObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToUShortObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToIntegerObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToUIntegerObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToLongObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToULongObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToSingleObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDoubleObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDecimalObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToDateObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToCharObject,

        Microsoft_VisualBasic_CompilerServices_Conversions__ToCharArrayRankOneObject,
        Microsoft_VisualBasic_CompilerServices_Conversions__ToGenericParameter_T_Object,

        Microsoft_VisualBasic_CompilerServices_Conversions__ChangeType,

        Microsoft_VisualBasic_CompilerServices_Operators__PlusObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__NegateObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__NotObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__AndObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__OrObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__XorObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__AddObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__SubtractObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__MultiplyObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__DivideObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__ExponentObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__ModObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__IntDivideObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__LeftShiftObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__RightShiftObjectObjectObject,
        Microsoft_VisualBasic_CompilerServices_Operators__ConcatenateObjectObjectObject,

        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectNotEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectLessObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectLessEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectGreaterEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareObjectGreaterObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectNotEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectLessObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectLessEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectGreaterEqualObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__ConditionalCompareObjectGreaterObjectObjectBoolean,
        Microsoft_VisualBasic_CompilerServices_Operators__CompareStringStringStringBoolean,
        Microsoft_VisualBasic_CompilerServices_EmbeddedOperators__CompareStringStringStringBoolean,

        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateCall,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateGet,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateSet,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateSetComplex,

        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateIndexGet,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateIndexSet,
        Microsoft_VisualBasic_CompilerServices_NewLateBinding__LateIndexSetComplex,

        Microsoft_VisualBasic_CompilerServices_StandardModuleAttribute__ctor,
        Microsoft_VisualBasic_CompilerServices_StaticLocalInitFlag__ctor,
        Microsoft_VisualBasic_CompilerServices_StaticLocalInitFlag__State,
        Microsoft_VisualBasic_CompilerServices_StringType__MidStmtStr,
        Microsoft_VisualBasic_CompilerServices_IncompleteInitialization__ctor,

        Microsoft_VisualBasic_Embedded__ctor,

        Microsoft_VisualBasic_CompilerServices_Utils__CopyArray,

        Microsoft_VisualBasic_CompilerServices_LikeOperator__LikeStringStringStringCompareMethod,
        Microsoft_VisualBasic_CompilerServices_LikeOperator__LikeObjectObjectObjectCompareMethod,

        Microsoft_VisualBasic_CompilerServices_ProjectData__CreateProjectError,
        Microsoft_VisualBasic_CompilerServices_ProjectData__SetProjectError,
        Microsoft_VisualBasic_CompilerServices_ProjectData__SetProjectError_Int32,
        Microsoft_VisualBasic_CompilerServices_ProjectData__ClearProjectError,
        Microsoft_VisualBasic_CompilerServices_ProjectData__EndApp,

        Microsoft_VisualBasic_CompilerServices_ObjectFlowControl_ForLoopControl__ForLoopInitObj,
        Microsoft_VisualBasic_CompilerServices_ObjectFlowControl_ForLoopControl__ForNextCheckObj,

        Microsoft_VisualBasic_CompilerServices_ObjectFlowControl__CheckForSyncLockOnValueType,

        Microsoft_VisualBasic_CompilerServices_Versioned__CallByName,
        Microsoft_VisualBasic_CompilerServices_Versioned__IsNumeric,
        Microsoft_VisualBasic_CompilerServices_Versioned__SystemTypeName,
        Microsoft_VisualBasic_CompilerServices_Versioned__TypeName,
        Microsoft_VisualBasic_CompilerServices_Versioned__VbTypeName,

        Microsoft_VisualBasic_Information__IsNumeric,
        Microsoft_VisualBasic_Information__SystemTypeName,
        Microsoft_VisualBasic_Information__TypeName,
        Microsoft_VisualBasic_Information__VbTypeName,
        Microsoft_VisualBasic_Interaction__CallByName,

        System_Runtime_CompilerServices_IAsyncStateMachine_MoveNext,
        System_Runtime_CompilerServices_IAsyncStateMachine_SetStateMachine,

        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Create,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetException,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetResult,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitOnCompleted,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_T,
        System_Runtime_CompilerServices_AsyncVoidMethodBuilder__SetStateMachine,

        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Create,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetException,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetResult,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitOnCompleted,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Start_T,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__SetStateMachine,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder__Task,

        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Create,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetException,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetResult,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__AwaitOnCompleted,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__AwaitUnsafeOnCompleted,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Start_T,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__SetStateMachine,
        System_Runtime_CompilerServices_AsyncTaskMethodBuilder_T__Task,

        System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor,
        System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor,

        Microsoft_VisualBasic_Strings__AscCharInt32,
        Microsoft_VisualBasic_Strings__AscStringInt32,
        Microsoft_VisualBasic_Strings__AscWCharInt32,
        Microsoft_VisualBasic_Strings__AscWStringInt32,
        Microsoft_VisualBasic_Strings__ChrInt32Char,
        Microsoft_VisualBasic_Strings__ChrWInt32Char,

        System_Xml_Linq_XElement__ctor,
        System_Xml_Linq_XElement__ctor2,
        System_Xml_Linq_XNamespace__Get,

        System_Windows_Forms_Application__RunForm,

        System_Environment__CurrentManagedThreadId,

        System_ComponentModel_EditorBrowsableAttribute__ctor,

        System_Runtime_GCLatencyMode__SustainedLowLatency,

        System_ValueTuple_T1__Item1,

        System_ValueTuple_T2__Item1,
        System_ValueTuple_T2__Item2,

        System_ValueTuple_T3__Item1,
        System_ValueTuple_T3__Item2,
        System_ValueTuple_T3__Item3,

        System_ValueTuple_T4__Item1,
        System_ValueTuple_T4__Item2,
        System_ValueTuple_T4__Item3,
        System_ValueTuple_T4__Item4,

        System_ValueTuple_T5__Item1,
        System_ValueTuple_T5__Item2,
        System_ValueTuple_T5__Item3,
        System_ValueTuple_T5__Item4,
        System_ValueTuple_T5__Item5,

        System_ValueTuple_T6__Item1,
        System_ValueTuple_T6__Item2,
        System_ValueTuple_T6__Item3,
        System_ValueTuple_T6__Item4,
        System_ValueTuple_T6__Item5,
        System_ValueTuple_T6__Item6,

        System_ValueTuple_T7__Item1,
        System_ValueTuple_T7__Item2,
        System_ValueTuple_T7__Item3,
        System_ValueTuple_T7__Item4,
        System_ValueTuple_T7__Item5,
        System_ValueTuple_T7__Item6,
        System_ValueTuple_T7__Item7,

        System_ValueTuple_TRest__Item1,
        System_ValueTuple_TRest__Item2,
        System_ValueTuple_TRest__Item3,
        System_ValueTuple_TRest__Item4,
        System_ValueTuple_TRest__Item5,
        System_ValueTuple_TRest__Item6,
        System_ValueTuple_TRest__Item7,
        System_ValueTuple_TRest__Rest,

        System_ValueTuple_T1__ctor,
        System_ValueTuple_T2__ctor,
        System_ValueTuple_T3__ctor,
        System_ValueTuple_T4__ctor,
        System_ValueTuple_T5__ctor,
        System_ValueTuple_T6__ctor,
        System_ValueTuple_T7__ctor,
        System_ValueTuple_TRest__ctor,

        System_Runtime_CompilerServices_TupleElementNamesAttribute__ctorTransformNames,

        System_String__Format_IFormatProvider,

        Microsoft_CodeAnalysis_Runtime_Instrumentation__CreatePayloadForMethodsSpanningSingleFile,
        Microsoft_CodeAnalysis_Runtime_Instrumentation__CreatePayloadForMethodsSpanningMultipleFiles,

        System_Runtime_CompilerServices_NullableAttribute__ctorByte,
        System_Runtime_CompilerServices_NullableAttribute__ctorTransformFlags,
        System_Runtime_CompilerServices_NullableContextAttribute__ctor,
        System_Runtime_CompilerServices_NullablePublicOnlyAttribute__ctor,
        System_Runtime_CompilerServices_ReferenceAssemblyAttribute__ctor,
        System_Runtime_CompilerServices_IsReadOnlyAttribute__ctor,
        System_Runtime_CompilerServices_IsByRefLikeAttribute__ctor,

        System_ObsoleteAttribute__ctor,

        System_Span_T__ctor_Pointer,
        System_Span_T__ctor_Array,
        System_Span_T__get_Item,
        System_Span_T__get_Length,

        System_ReadOnlySpan_T__ctor_Pointer,
        System_ReadOnlySpan_T__ctor_Array,
        System_ReadOnlySpan_T__ctor_Array_Start_Length,
        System_ReadOnlySpan_T__get_Item,
        System_ReadOnlySpan_T__get_Length,

        System_Runtime_CompilerServices_IsUnmanagedAttribute__ctor,

        Microsoft_VisualBasic_Conversion__FixSingle,
        Microsoft_VisualBasic_Conversion__FixDouble,
        Microsoft_VisualBasic_Conversion__IntSingle,
        Microsoft_VisualBasic_Conversion__IntDouble,

        System_Math__CeilingDouble,
        System_Math__FloorDouble,
        System_Math__TruncateDouble,

        System_Index__ctor,
        System_Index__GetOffset,
        System_Range__ctor,
        System_Range__StartAt,
        System_Range__EndAt,
        System_Range__get_All,
        System_Range__get_Start,
        System_Range__get_End,

        System_Runtime_CompilerServices_AsyncIteratorStateMachineAttribute__ctor,

        System_IAsyncDisposable__DisposeAsync,
        System_Collections_Generic_IAsyncEnumerable_T__GetAsyncEnumerator,
        System_Collections_Generic_IAsyncEnumerator_T__MoveNextAsync,
        System_Collections_Generic_IAsyncEnumerator_T__get_Current,

        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetResult,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__GetStatus,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__OnCompleted,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__Reset,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetException,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__SetResult,
        System_Threading_Tasks_Sources_ManualResetValueTaskSourceCore_T__get_Version,
        System_Threading_Tasks_Sources_IValueTaskSource_T__GetResult,
        System_Threading_Tasks_Sources_IValueTaskSource_T__GetStatus,
        System_Threading_Tasks_Sources_IValueTaskSource_T__OnCompleted,
        System_Threading_Tasks_Sources_IValueTaskSource__GetResult,
        System_Threading_Tasks_Sources_IValueTaskSource__GetStatus,
        System_Threading_Tasks_Sources_IValueTaskSource__OnCompleted,
        System_Threading_Tasks_ValueTask_T__ctorSourceAndToken,
        System_Threading_Tasks_ValueTask_T__ctorValue,
        System_Threading_Tasks_ValueTask__ctor,

        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__Create,
        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__Complete,
        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__AwaitOnCompleted,
        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__AwaitUnsafeOnCompleted,
        System_Runtime_CompilerServices_AsyncIteratorMethodBuilder__MoveNext_T,

        System_Runtime_CompilerServices_ITuple__get_Item,
        System_Runtime_CompilerServices_ITuple__get_Length,

        System_InvalidOperationException__ctor,
        System_InvalidOperationException__ctorString,
        System_Runtime_CompilerServices_SwitchExpressionException__ctor,
        System_Runtime_CompilerServices_SwitchExpressionException__ctorObject,

        System_Threading_CancellationToken__Equals,
        System_Threading_CancellationTokenSource__CreateLinkedTokenSource,
        System_Threading_CancellationTokenSource__Token,
        System_Threading_CancellationTokenSource__Dispose,

        System_ArgumentNullException__ctorString,

        System_Runtime_CompilerServices_NativeIntegerAttribute__ctor,
        System_Runtime_CompilerServices_NativeIntegerAttribute__ctorTransformFlags,

        System_Text_StringBuilder__AppendString,
        System_Text_StringBuilder__AppendChar,
        System_Text_StringBuilder__AppendObject,
        System_Text_StringBuilder__ctor,

        System_Runtime_CompilerServices_DefaultInterpolatedStringHandler__ToStringAndClear,
        System_Runtime_CompilerServices_RequiredMemberAttribute__ctor,
        System_Diagnostics_CodeAnalysis_SetsRequiredMembersAttribute__ctor,
        System_Runtime_CompilerServices_LifetimeAnnotationAttribute__ctor,

        System_MemoryExtensions__SequenceEqual_Span_T,
        System_MemoryExtensions__SequenceEqual_ReadOnlySpan_T,
        System_MemoryExtensions__AsSpan_String,

        System_Runtime_CompilerServices_CompilerFeatureRequiredAttribute__ctor,

        System_MissingMethodException__ctor,

        System_GC__AllocateUninitializedArray_T,

        Count

        // Remember to update the AllWellKnownTypeMembers tests when making changes here
    }
}
