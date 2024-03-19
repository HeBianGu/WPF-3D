using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B36 RID: 2870
	public class vtkTypeUInt32Array : vtkUnsignedIntArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E0F6 RID: 123126 RVA: 0x002A7E7F File Offset: 0x002A607F
		static vtkTypeUInt32Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt32Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt32Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0F7 RID: 123127 RVA: 0x002A7EA7 File Offset: 0x002A60A7
		public vtkTypeUInt32Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E0F8 RID: 123128
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt32Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x002A7EB8 File Offset: 0x002A60B8
		public new static vtkTypeUInt32Array New()
		{
			vtkTypeUInt32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt32Array.vtkTypeUInt32Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x002A7F0C File Offset: 0x002A610C
		public vtkTypeUInt32Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeUInt32Array.vtkTypeUInt32Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E0FB RID: 123131 RVA: 0x002A7F50 File Offset: 0x002A6150
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E0FC RID: 123132
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt32Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E0FD RID: 123133 RVA: 0x002A7F5C File Offset: 0x002A615C
		public new static vtkTypeUInt32Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeUInt32Array vtkTypeUInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt32Array.vtkTypeUInt32Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt32Array = (vtkTypeUInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt32Array.Register(null);
				}
			}
			return vtkTypeUInt32Array;
		}

		// Token: 0x0601E0FE RID: 123134
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt32Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E0FF RID: 123135 RVA: 0x002A7FDC File Offset: 0x002A61DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeUInt32Array.vtkTypeUInt32Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E100 RID: 123136
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt32Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E101 RID: 123137 RVA: 0x002A7FFC File Offset: 0x002A61FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeUInt32Array.vtkTypeUInt32Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E102 RID: 123138
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt32Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E103 RID: 123139 RVA: 0x002A8018 File Offset: 0x002A6218
		public override int IsA(string type)
		{
			return vtkTypeUInt32Array.vtkTypeUInt32Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E104 RID: 123140
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt32Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E105 RID: 123141 RVA: 0x002A8038 File Offset: 0x002A6238
		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt32Array.vtkTypeUInt32Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E106 RID: 123142
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt32Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E107 RID: 123143 RVA: 0x002A8054 File Offset: 0x002A6254
		public new vtkTypeUInt32Array NewInstance()
		{
			vtkTypeUInt32Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt32Array.vtkTypeUInt32Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E108 RID: 123144
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt32Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E109 RID: 123145 RVA: 0x002A80B0 File Offset: 0x002A62B0
		public new static vtkTypeUInt32Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt32Array vtkTypeUInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt32Array.vtkTypeUInt32Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt32Array = (vtkTypeUInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt32Array.Register(null);
				}
			}
			return vtkTypeUInt32Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBB RID: 8123
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt32Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBC RID: 8124
		public new static readonly string MRClassNameKey = "class vtkTypeUInt32Array";
	}
}
