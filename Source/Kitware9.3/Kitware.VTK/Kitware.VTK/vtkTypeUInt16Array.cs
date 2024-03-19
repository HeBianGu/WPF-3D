using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B34 RID: 2868
	public class vtkTypeUInt16Array : vtkUnsignedShortArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E0C8 RID: 123080 RVA: 0x002A787B File Offset: 0x002A5A7B
		static vtkTypeUInt16Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt16Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt16Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0C9 RID: 123081 RVA: 0x002A78A3 File Offset: 0x002A5AA3
		public vtkTypeUInt16Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E0CA RID: 123082
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt16Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0CB RID: 123083 RVA: 0x002A78B4 File Offset: 0x002A5AB4
		public new static vtkTypeUInt16Array New()
		{
			vtkTypeUInt16Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0CC RID: 123084 RVA: 0x002A7908 File Offset: 0x002A5B08
		public vtkTypeUInt16Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeUInt16Array.vtkTypeUInt16Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0CD RID: 123085 RVA: 0x002A794C File Offset: 0x002A5B4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E0CE RID: 123086
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt16Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0CF RID: 123087 RVA: 0x002A7958 File Offset: 0x002A5B58
		public new static vtkTypeUInt16Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeUInt16Array vtkTypeUInt16Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt16Array = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt16Array.Register(null);
				}
			}
			return vtkTypeUInt16Array;
		}

		// Token: 0x0601E0D0 RID: 123088
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt16Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0D1 RID: 123089 RVA: 0x002A79D8 File Offset: 0x002A5BD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E0D2 RID: 123090
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt16Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0D3 RID: 123091 RVA: 0x002A79F8 File Offset: 0x002A5BF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E0D4 RID: 123092
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt16Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0D5 RID: 123093 RVA: 0x002A7A14 File Offset: 0x002A5C14
		public override int IsA(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E0D6 RID: 123094
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt16Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0D7 RID: 123095 RVA: 0x002A7A34 File Offset: 0x002A5C34
		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E0D8 RID: 123096
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt16Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0D9 RID: 123097 RVA: 0x002A7A50 File Offset: 0x002A5C50
		public new vtkTypeUInt16Array NewInstance()
		{
			vtkTypeUInt16Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0DA RID: 123098
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt16Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0DB RID: 123099 RVA: 0x002A7AAC File Offset: 0x002A5CAC
		public new static vtkTypeUInt16Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt16Array vtkTypeUInt16Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt16Array = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt16Array.Register(null);
				}
			}
			return vtkTypeUInt16Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB7 RID: 8119
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt16Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB8 RID: 8120
		public new static readonly string MRClassNameKey = "class vtkTypeUInt16Array";
	}
}
