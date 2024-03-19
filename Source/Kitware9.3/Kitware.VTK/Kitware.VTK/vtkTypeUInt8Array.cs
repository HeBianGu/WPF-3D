using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B32 RID: 2866
	public class vtkTypeUInt8Array : vtkUnsignedCharArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E09A RID: 123034 RVA: 0x002A7277 File Offset: 0x002A5477
		static vtkTypeUInt8Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt8Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt8Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E09B RID: 123035 RVA: 0x002A729F File Offset: 0x002A549F
		public vtkTypeUInt8Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E09C RID: 123036
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt8Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E09D RID: 123037 RVA: 0x002A72B0 File Offset: 0x002A54B0
		public new static vtkTypeUInt8Array New()
		{
			vtkTypeUInt8Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E09E RID: 123038 RVA: 0x002A7304 File Offset: 0x002A5504
		public vtkTypeUInt8Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeUInt8Array.vtkTypeUInt8Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E09F RID: 123039 RVA: 0x002A7348 File Offset: 0x002A5548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E0A0 RID: 123040
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt8Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0A1 RID: 123041 RVA: 0x002A7354 File Offset: 0x002A5554
		public new static vtkTypeUInt8Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeUInt8Array vtkTypeUInt8Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt8Array = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt8Array.Register(null);
				}
			}
			return vtkTypeUInt8Array;
		}

		// Token: 0x0601E0A2 RID: 123042
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt8Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0A3 RID: 123043 RVA: 0x002A73D4 File Offset: 0x002A55D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E0A4 RID: 123044
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt8Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0A5 RID: 123045 RVA: 0x002A73F4 File Offset: 0x002A55F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E0A6 RID: 123046
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt8Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0A7 RID: 123047 RVA: 0x002A7410 File Offset: 0x002A5610
		public override int IsA(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E0A8 RID: 123048
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt8Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0A9 RID: 123049 RVA: 0x002A7430 File Offset: 0x002A5630
		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E0AA RID: 123050
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt8Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0AB RID: 123051 RVA: 0x002A744C File Offset: 0x002A564C
		public new vtkTypeUInt8Array NewInstance()
		{
			vtkTypeUInt8Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0AC RID: 123052
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt8Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0AD RID: 123053 RVA: 0x002A74A8 File Offset: 0x002A56A8
		public new static vtkTypeUInt8Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt8Array vtkTypeUInt8Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt8Array = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt8Array.Register(null);
				}
			}
			return vtkTypeUInt8Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB3 RID: 8115
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt8Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB4 RID: 8116
		public new static readonly string MRClassNameKey = "class vtkTypeUInt8Array";
	}
}
