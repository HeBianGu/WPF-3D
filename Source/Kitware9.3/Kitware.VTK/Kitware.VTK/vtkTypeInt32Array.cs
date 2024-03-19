using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B2E RID: 2862
	public class vtkTypeInt32Array : vtkIntArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E03E RID: 122942 RVA: 0x002A666F File Offset: 0x002A486F
		static vtkTypeInt32Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeInt32Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt32Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E03F RID: 122943 RVA: 0x002A6697 File Offset: 0x002A4897
		public vtkTypeInt32Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E040 RID: 122944
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt32Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E041 RID: 122945 RVA: 0x002A66A8 File Offset: 0x002A48A8
		public new static vtkTypeInt32Array New()
		{
			vtkTypeInt32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt32Array.vtkTypeInt32Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E042 RID: 122946 RVA: 0x002A66FC File Offset: 0x002A48FC
		public vtkTypeInt32Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeInt32Array.vtkTypeInt32Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E043 RID: 122947 RVA: 0x002A6740 File Offset: 0x002A4940
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E044 RID: 122948
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt32Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E045 RID: 122949 RVA: 0x002A674C File Offset: 0x002A494C
		public new static vtkTypeInt32Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt32Array.vtkTypeInt32Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0601E046 RID: 122950
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt32Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E047 RID: 122951 RVA: 0x002A67CC File Offset: 0x002A49CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeInt32Array.vtkTypeInt32Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E048 RID: 122952
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt32Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E049 RID: 122953 RVA: 0x002A67EC File Offset: 0x002A49EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeInt32Array.vtkTypeInt32Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E04A RID: 122954
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt32Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E04B RID: 122955 RVA: 0x002A6808 File Offset: 0x002A4A08
		public override int IsA(string type)
		{
			return vtkTypeInt32Array.vtkTypeInt32Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E04C RID: 122956
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt32Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E04D RID: 122957 RVA: 0x002A6828 File Offset: 0x002A4A28
		public new static int IsTypeOf(string type)
		{
			return vtkTypeInt32Array.vtkTypeInt32Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E04E RID: 122958
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt32Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E04F RID: 122959 RVA: 0x002A6844 File Offset: 0x002A4A44
		public new vtkTypeInt32Array NewInstance()
		{
			vtkTypeInt32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt32Array.vtkTypeInt32Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E050 RID: 122960
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt32Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E051 RID: 122961 RVA: 0x002A68A0 File Offset: 0x002A4AA0
		public new static vtkTypeInt32Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt32Array.vtkTypeInt32Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAB RID: 8107
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt32Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAC RID: 8108
		public new static readonly string MRClassNameKey = "class vtkTypeInt32Array";
	}
}
