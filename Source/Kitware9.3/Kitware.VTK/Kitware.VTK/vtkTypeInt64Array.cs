using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B30 RID: 2864
	public class vtkTypeInt64Array : vtkLongLongArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E06C RID: 122988 RVA: 0x002A6C73 File Offset: 0x002A4E73
		static vtkTypeInt64Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeInt64Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt64Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E06D RID: 122989 RVA: 0x002A6C9B File Offset: 0x002A4E9B
		public vtkTypeInt64Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E06E RID: 122990
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt64Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E06F RID: 122991 RVA: 0x002A6CAC File Offset: 0x002A4EAC
		public new static vtkTypeInt64Array New()
		{
			vtkTypeInt64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt64Array.vtkTypeInt64Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E070 RID: 122992 RVA: 0x002A6D00 File Offset: 0x002A4F00
		public vtkTypeInt64Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeInt64Array.vtkTypeInt64Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E071 RID: 122993 RVA: 0x002A6D44 File Offset: 0x002A4F44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E072 RID: 122994
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt64Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E073 RID: 122995 RVA: 0x002A6D50 File Offset: 0x002A4F50
		public new static vtkTypeInt64Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeInt64Array vtkTypeInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt64Array.vtkTypeInt64Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt64Array = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt64Array.Register(null);
				}
			}
			return vtkTypeInt64Array;
		}

		// Token: 0x0601E074 RID: 122996
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt64Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E075 RID: 122997 RVA: 0x002A6DD0 File Offset: 0x002A4FD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeInt64Array.vtkTypeInt64Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E076 RID: 122998
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt64Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E077 RID: 122999 RVA: 0x002A6DF0 File Offset: 0x002A4FF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeInt64Array.vtkTypeInt64Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E078 RID: 123000
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt64Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E079 RID: 123001 RVA: 0x002A6E0C File Offset: 0x002A500C
		public override int IsA(string type)
		{
			return vtkTypeInt64Array.vtkTypeInt64Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E07A RID: 123002
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt64Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E07B RID: 123003 RVA: 0x002A6E2C File Offset: 0x002A502C
		public new static int IsTypeOf(string type)
		{
			return vtkTypeInt64Array.vtkTypeInt64Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E07C RID: 123004
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt64Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E07D RID: 123005 RVA: 0x002A6E48 File Offset: 0x002A5048
		public new vtkTypeInt64Array NewInstance()
		{
			vtkTypeInt64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt64Array.vtkTypeInt64Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E07E RID: 123006
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt64Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E07F RID: 123007 RVA: 0x002A6EA4 File Offset: 0x002A50A4
		public new static vtkTypeInt64Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeInt64Array vtkTypeInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt64Array.vtkTypeInt64Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt64Array = (vtkTypeInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt64Array.Register(null);
				}
			}
			return vtkTypeInt64Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FAF RID: 8111
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt64Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FB0 RID: 8112
		public new static readonly string MRClassNameKey = "class vtkTypeInt64Array";
	}
}
