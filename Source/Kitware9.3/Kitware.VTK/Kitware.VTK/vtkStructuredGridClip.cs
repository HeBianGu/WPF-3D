using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridClip
	/// </summary>
	/// <remarks>
	///    Reduces the image extent of the input.
	///
	/// vtkStructuredGridClip  will make an image smaller.  The output must have
	/// an image extent which is the subset of the input.  The filter has two
	/// modes of operation:
	/// 1: By default, the data is not copied in this filter.
	/// Only the whole extent is modified.
	/// 2: If ClipDataOn is set, then you will get no more that the clipped
	/// extent.
	/// </remarks>
	// Token: 0x020008E7 RID: 2279
	public class vtkStructuredGridClip : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601784F RID: 96335 RVA: 0x0021002F File Offset: 0x0020E22F
		static vtkStructuredGridClip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridClip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017850 RID: 96336 RVA: 0x00210057 File Offset: 0x0020E257
		public vtkStructuredGridClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017851 RID: 96337
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017852 RID: 96338 RVA: 0x00210068 File Offset: 0x0020E268
		public new static vtkStructuredGridClip New()
		{
			vtkStructuredGridClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017853 RID: 96339 RVA: 0x002100BC File Offset: 0x0020E2BC
		public vtkStructuredGridClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridClip.vtkStructuredGridClip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017854 RID: 96340 RVA: 0x00210100 File Offset: 0x0020E300
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017855 RID: 96341
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_ClipDataOff_01(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06017856 RID: 96342 RVA: 0x0021010B File Offset: 0x0020E30B
		public virtual void ClipDataOff()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ClipDataOff_01(base.GetCppThis());
		}

		// Token: 0x06017857 RID: 96343
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_ClipDataOn_02(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06017858 RID: 96344 RVA: 0x0021011A File Offset: 0x0020E31A
		public virtual void ClipDataOn()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ClipDataOn_02(base.GetCppThis());
		}

		// Token: 0x06017859 RID: 96345
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridClip_GetClipData_03(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x0601785A RID: 96346 RVA: 0x0021012C File Offset: 0x0020E32C
		public virtual int GetClipData()
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetClipData_03(base.GetCppThis());
		}

		// Token: 0x0601785B RID: 96347
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridClip_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601785C RID: 96348 RVA: 0x0021014C File Offset: 0x0020E34C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601785D RID: 96349
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridClip_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601785E RID: 96350 RVA: 0x0021016C File Offset: 0x0020E36C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601785F RID: 96351
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_GetOutputWholeExtent_06(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017860 RID: 96352 RVA: 0x00210186 File Offset: 0x0020E386
		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_GetOutputWholeExtent_06(base.GetCppThis(), extent);
		}

		// Token: 0x06017861 RID: 96353
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridClip_GetOutputWholeExtent_07(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017862 RID: 96354 RVA: 0x00210198 File Offset: 0x0020E398
		public IntPtr GetOutputWholeExtent()
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetOutputWholeExtent_07(base.GetCppThis());
		}

		// Token: 0x06017863 RID: 96355
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridClip_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017864 RID: 96356 RVA: 0x002101B8 File Offset: 0x0020E3B8
		public override int IsA(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06017865 RID: 96357
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridClip_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017866 RID: 96358 RVA: 0x002101D8 File Offset: 0x0020E3D8
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_IsTypeOf_09(type);
		}

		// Token: 0x06017867 RID: 96359
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017868 RID: 96360 RVA: 0x002101F4 File Offset: 0x0020E3F4
		public new vtkStructuredGridClip NewInstance()
		{
			vtkStructuredGridClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017869 RID: 96361
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_ResetOutputWholeExtent_12(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x0601786A RID: 96362 RVA: 0x0021024E File Offset: 0x0020E44E
		public void ResetOutputWholeExtent()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ResetOutputWholeExtent_12(base.GetCppThis());
		}

		// Token: 0x0601786B RID: 96363
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601786C RID: 96364 RVA: 0x00210260 File Offset: 0x0020E460
		public new static vtkStructuredGridClip SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridClip vtkStructuredGridClip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridClip = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridClip.Register(null);
				}
			}
			return vtkStructuredGridClip;
		}

		// Token: 0x0601786D RID: 96365
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_SetClipData_14(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x0601786E RID: 96366 RVA: 0x002102DF File Offset: 0x0020E4DF
		public virtual void SetClipData(int _arg)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetClipData_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601786F RID: 96367
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_SetOutputWholeExtent_15(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017870 RID: 96368 RVA: 0x002102F0 File Offset: 0x0020E4F0
		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetOutputWholeExtent_15(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x06017871 RID: 96369
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridClip_SetOutputWholeExtent_16(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06017872 RID: 96370 RVA: 0x00210320 File Offset: 0x0020E520
		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetOutputWholeExtent_16(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A48 RID: 6728
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridClip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A49 RID: 6729
		public new static readonly string MRClassNameKey = "class vtkStructuredGridClip";
	}
}
