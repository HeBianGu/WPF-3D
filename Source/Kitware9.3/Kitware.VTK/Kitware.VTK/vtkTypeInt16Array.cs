using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B2C RID: 2860
	public class vtkTypeInt16Array : vtkShortArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E010 RID: 122896 RVA: 0x002A606B File Offset: 0x002A426B
		static vtkTypeInt16Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeInt16Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt16Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E011 RID: 122897 RVA: 0x002A6093 File Offset: 0x002A4293
		public vtkTypeInt16Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E012 RID: 122898
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt16Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E013 RID: 122899 RVA: 0x002A60A4 File Offset: 0x002A42A4
		public new static vtkTypeInt16Array New()
		{
			vtkTypeInt16Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt16Array.vtkTypeInt16Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E014 RID: 122900 RVA: 0x002A60F8 File Offset: 0x002A42F8
		public vtkTypeInt16Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeInt16Array.vtkTypeInt16Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E015 RID: 122901 RVA: 0x002A613C File Offset: 0x002A433C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E016 RID: 122902
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt16Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E017 RID: 122903 RVA: 0x002A6148 File Offset: 0x002A4348
		public new static vtkTypeInt16Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeInt16Array vtkTypeInt16Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt16Array.vtkTypeInt16Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt16Array = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt16Array.Register(null);
				}
			}
			return vtkTypeInt16Array;
		}

		// Token: 0x0601E018 RID: 122904
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt16Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E019 RID: 122905 RVA: 0x002A61C8 File Offset: 0x002A43C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeInt16Array.vtkTypeInt16Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E01A RID: 122906
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeInt16Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E01B RID: 122907 RVA: 0x002A61E8 File Offset: 0x002A43E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeInt16Array.vtkTypeInt16Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E01C RID: 122908
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt16Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E01D RID: 122909 RVA: 0x002A6204 File Offset: 0x002A4404
		public override int IsA(string type)
		{
			return vtkTypeInt16Array.vtkTypeInt16Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E01E RID: 122910
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeInt16Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E01F RID: 122911 RVA: 0x002A6224 File Offset: 0x002A4424
		public new static int IsTypeOf(string type)
		{
			return vtkTypeInt16Array.vtkTypeInt16Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E020 RID: 122912
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt16Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E021 RID: 122913 RVA: 0x002A6240 File Offset: 0x002A4440
		public new vtkTypeInt16Array NewInstance()
		{
			vtkTypeInt16Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt16Array.vtkTypeInt16Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E022 RID: 122914
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeInt16Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E023 RID: 122915 RVA: 0x002A629C File Offset: 0x002A449C
		public new static vtkTypeInt16Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeInt16Array vtkTypeInt16Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeInt16Array.vtkTypeInt16Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt16Array = (vtkTypeInt16Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt16Array.Register(null);
				}
			}
			return vtkTypeInt16Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA7 RID: 8103
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt16Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA8 RID: 8104
		public new static readonly string MRClassNameKey = "class vtkTypeInt16Array";
	}
}
