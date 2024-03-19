using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridClip
	/// </summary>
	/// <remarks>
	///    Reduces the image extent of the input.
	///
	/// vtkRectilinearGridClip  will make an image smaller.  The output must have
	/// an image extent which is the subset of the input.  The filter has two
	/// modes of operation:
	/// 1: By default, the data is not copied in this filter.
	/// Only the whole extent is modified.
	/// 2: If ClipDataOn is set, then you will get no more that the clipped
	/// extent.
	/// </remarks>
	// Token: 0x020008D4 RID: 2260
	public class vtkRectilinearGridClip : vtkRectilinearGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017603 RID: 95747 RVA: 0x0020CB0E File Offset: 0x0020AD0E
		static vtkRectilinearGridClip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridClip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017604 RID: 95748 RVA: 0x0020CB36 File Offset: 0x0020AD36
		public vtkRectilinearGridClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017605 RID: 95749
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017606 RID: 95750 RVA: 0x0020CB44 File Offset: 0x0020AD44
		public new static vtkRectilinearGridClip New()
		{
			vtkRectilinearGridClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017607 RID: 95751 RVA: 0x0020CB98 File Offset: 0x0020AD98
		public vtkRectilinearGridClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridClip.vtkRectilinearGridClip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017608 RID: 95752 RVA: 0x0020CBDC File Offset: 0x0020ADDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017609 RID: 95753
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_ClipDataOff_01(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x0601760A RID: 95754 RVA: 0x0020CBE7 File Offset: 0x0020ADE7
		public virtual void ClipDataOff()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ClipDataOff_01(base.GetCppThis());
		}

		// Token: 0x0601760B RID: 95755
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_ClipDataOn_02(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x0601760C RID: 95756 RVA: 0x0020CBF6 File Offset: 0x0020ADF6
		public virtual void ClipDataOn()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ClipDataOn_02(base.GetCppThis());
		}

		// Token: 0x0601760D RID: 95757
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridClip_GetClipData_03(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x0601760E RID: 95758 RVA: 0x0020CC08 File Offset: 0x0020AE08
		public virtual int GetClipData()
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetClipData_03(base.GetCppThis());
		}

		// Token: 0x0601760F RID: 95759
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridClip_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017610 RID: 95760 RVA: 0x0020CC28 File Offset: 0x0020AE28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06017611 RID: 95761
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridClip_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017612 RID: 95762 RVA: 0x0020CC48 File Offset: 0x0020AE48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06017613 RID: 95763
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_GetOutputWholeExtent_06(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017614 RID: 95764 RVA: 0x0020CC62 File Offset: 0x0020AE62
		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_GetOutputWholeExtent_06(base.GetCppThis(), extent);
		}

		// Token: 0x06017615 RID: 95765
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridClip_GetOutputWholeExtent_07(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017616 RID: 95766 RVA: 0x0020CC74 File Offset: 0x0020AE74
		public IntPtr GetOutputWholeExtent()
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetOutputWholeExtent_07(base.GetCppThis());
		}

		// Token: 0x06017617 RID: 95767
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridClip_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017618 RID: 95768 RVA: 0x0020CC94 File Offset: 0x0020AE94
		public override int IsA(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06017619 RID: 95769
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridClip_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601761A RID: 95770 RVA: 0x0020CCB4 File Offset: 0x0020AEB4
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_IsTypeOf_09(type);
		}

		// Token: 0x0601761B RID: 95771
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601761C RID: 95772 RVA: 0x0020CCD0 File Offset: 0x0020AED0
		public new vtkRectilinearGridClip NewInstance()
		{
			vtkRectilinearGridClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601761D RID: 95773
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_ResetOutputWholeExtent_12(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x0601761E RID: 95774 RVA: 0x0020CD2A File Offset: 0x0020AF2A
		public void ResetOutputWholeExtent()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ResetOutputWholeExtent_12(base.GetCppThis());
		}

		// Token: 0x0601761F RID: 95775
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017620 RID: 95776 RVA: 0x0020CD3C File Offset: 0x0020AF3C
		public new static vtkRectilinearGridClip SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridClip vtkRectilinearGridClip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridClip = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridClip.Register(null);
				}
			}
			return vtkRectilinearGridClip;
		}

		// Token: 0x06017621 RID: 95777
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_SetClipData_14(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06017622 RID: 95778 RVA: 0x0020CDBB File Offset: 0x0020AFBB
		public virtual void SetClipData(int _arg)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetClipData_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06017623 RID: 95779
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_15(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017624 RID: 95780 RVA: 0x0020CDCC File Offset: 0x0020AFCC
		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetOutputWholeExtent_15(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x06017625 RID: 95781
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_16(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017626 RID: 95782 RVA: 0x0020CDFC File Offset: 0x0020AFFC
		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetOutputWholeExtent_16(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1B RID: 6683
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridClip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1C RID: 6684
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridClip";
	}
}
