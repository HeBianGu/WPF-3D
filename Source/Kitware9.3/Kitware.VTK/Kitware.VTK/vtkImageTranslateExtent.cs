using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageTranslateExtent
	/// </summary>
	/// <remarks>
	///    Changes extent, nothing else.
	///
	/// vtkImageTranslateExtent shift the whole extent, but does not
	/// change the data.
	/// </remarks>
	// Token: 0x0200086A RID: 2154
	public class vtkImageTranslateExtent : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060165E8 RID: 91624 RVA: 0x001F7299 File Offset: 0x001F5499
		static vtkImageTranslateExtent()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTranslateExtent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTranslateExtent"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060165E9 RID: 91625 RVA: 0x001F72C1 File Offset: 0x001F54C1
		public vtkImageTranslateExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060165EA RID: 91626
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTranslateExtent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165EB RID: 91627 RVA: 0x001F72D0 File Offset: 0x001F54D0
		public new static vtkImageTranslateExtent New()
		{
			vtkImageTranslateExtent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165EC RID: 91628 RVA: 0x001F7324 File Offset: 0x001F5524
		public vtkImageTranslateExtent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageTranslateExtent.vtkImageTranslateExtent_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060165ED RID: 91629 RVA: 0x001F7368 File Offset: 0x001F5568
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060165EE RID: 91630
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTranslateExtent_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165EF RID: 91631 RVA: 0x001F7374 File Offset: 0x001F5574
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060165F0 RID: 91632
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageTranslateExtent_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165F1 RID: 91633 RVA: 0x001F7394 File Offset: 0x001F5594
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060165F2 RID: 91634
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTranslateExtent_GetTranslation_03(HandleRef pThis);

		/// <summary>
		/// Delta to change "WholeExtent". -1 changes 0-&gt;10 to -1-&gt;9.
		/// </summary>
		// Token: 0x060165F3 RID: 91635 RVA: 0x001F73B0 File Offset: 0x001F55B0
		public virtual int[] GetTranslation()
		{
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060165F4 RID: 91636
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTranslateExtent_GetTranslation_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Delta to change "WholeExtent". -1 changes 0-&gt;10 to -1-&gt;9.
		/// </summary>
		// Token: 0x060165F5 RID: 91637 RVA: 0x001F73F8 File Offset: 0x001F55F8
		public virtual void GetTranslation(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060165F6 RID: 91638
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTranslateExtent_GetTranslation_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Delta to change "WholeExtent". -1 changes 0-&gt;10 to -1-&gt;9.
		/// </summary>
		// Token: 0x060165F7 RID: 91639 RVA: 0x001F740A File Offset: 0x001F560A
		public virtual void GetTranslation(IntPtr _arg)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_05(base.GetCppThis(), _arg);
		}

		// Token: 0x060165F8 RID: 91640
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTranslateExtent_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165F9 RID: 91641 RVA: 0x001F741C File Offset: 0x001F561C
		public override int IsA(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060165FA RID: 91642
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageTranslateExtent_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165FB RID: 91643 RVA: 0x001F743C File Offset: 0x001F563C
		public new static int IsTypeOf(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_IsTypeOf_07(type);
		}

		// Token: 0x060165FC RID: 91644
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTranslateExtent_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165FD RID: 91645 RVA: 0x001F7458 File Offset: 0x001F5658
		public new vtkImageTranslateExtent NewInstance()
		{
			vtkImageTranslateExtent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060165FE RID: 91646
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageTranslateExtent_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060165FF RID: 91647 RVA: 0x001F74B4 File Offset: 0x001F56B4
		public new static vtkImageTranslateExtent SafeDownCast(vtkObjectBase o)
		{
			vtkImageTranslateExtent vtkImageTranslateExtent = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTranslateExtent = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTranslateExtent.Register(null);
				}
			}
			return vtkImageTranslateExtent;
		}

		// Token: 0x06016600 RID: 91648
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTranslateExtent_SetTranslation_11(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Delta to change "WholeExtent". -1 changes 0-&gt;10 to -1-&gt;9.
		/// </summary>
		// Token: 0x06016601 RID: 91649 RVA: 0x001F7533 File Offset: 0x001F5733
		public virtual void SetTranslation(int _arg1, int _arg2, int _arg3)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_SetTranslation_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016602 RID: 91650
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageTranslateExtent_SetTranslation_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Delta to change "WholeExtent". -1 changes 0-&gt;10 to -1-&gt;9.
		/// </summary>
		// Token: 0x06016603 RID: 91651 RVA: 0x001F7545 File Offset: 0x001F5745
		public virtual void SetTranslation(IntPtr _arg)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_SetTranslation_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192A RID: 6442
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTranslateExtent";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192B RID: 6443
		public new static readonly string MRClassNameKey = "class vtkImageTranslateExtent";
	}
}
