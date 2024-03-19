using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStencilData
	/// </summary>
	/// <remarks>
	///    efficient description of an image stencil
	///
	/// vtkImageStencilData describes an image stencil in a manner which is
	/// efficient both in terms of speed and storage space.  The stencil extents
	/// are stored for each x-row across the image (multiple extents per row if
	/// necessary) and can be retrieved via the GetNextExtent() method.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageStencilSource vtkImageStencil
	/// </seealso>
	// Token: 0x02000868 RID: 2152
	public class vtkImageStencilData : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016540 RID: 91456 RVA: 0x001F66A8 File Offset: 0x001F48A8
		static vtkImageStencilData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016541 RID: 91457 RVA: 0x001F66D0 File Offset: 0x001F48D0
		public vtkImageStencilData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016542 RID: 91458
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016543 RID: 91459 RVA: 0x001F66E0 File Offset: 0x001F48E0
		public new static vtkImageStencilData New()
		{
			vtkImageStencilData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016544 RID: 91460 RVA: 0x001F6734 File Offset: 0x001F4934
		public vtkImageStencilData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStencilData.vtkImageStencilData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016545 RID: 91461 RVA: 0x001F6778 File Offset: 0x001F4978
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016546 RID: 91462
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_Add_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add merges the stencil supplied as argument into Self.
		/// </summary>
		// Token: 0x06016547 RID: 91463 RVA: 0x001F6784 File Offset: 0x001F4984
		public virtual void Add(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Add_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016548 RID: 91464
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_AllocateExtents_02(HandleRef pThis);

		/// <summary>
		/// Allocate space for the sub-extents.  This is called by
		/// vtkImageStencilSource.
		/// </summary>
		// Token: 0x06016549 RID: 91465 RVA: 0x001F67B3 File Offset: 0x001F49B3
		public void AllocateExtents()
		{
			vtkImageStencilData.vtkImageStencilData_AllocateExtents_02(base.GetCppThis());
		}

		// Token: 0x0601654A RID: 91466
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_Clip_03(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Clip the stencil with the supplied extents. In other words, discard data
		/// outside the specified extents. Return 1 if something changed.
		/// </summary>
		// Token: 0x0601654B RID: 91467 RVA: 0x001F67C4 File Offset: 0x001F49C4
		public virtual int Clip(IntPtr extent)
		{
			return vtkImageStencilData.vtkImageStencilData_Clip_03(base.GetCppThis(), extent);
		}

		// Token: 0x0601654C RID: 91468
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_CopyInformationFromPipeline_04(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Override these to handle origin, spacing, scalar type, and scalar
		/// number of components.  See vtkDataObject for details.
		/// </summary>
		// Token: 0x0601654D RID: 91469 RVA: 0x001F67E4 File Offset: 0x001F49E4
		public override void CopyInformationFromPipeline(vtkInformation info)
		{
			vtkImageStencilData.vtkImageStencilData_CopyInformationFromPipeline_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601654E RID: 91470
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_CopyInformationToPipeline_05(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Override these to handle origin, spacing, scalar type, and scalar
		/// number of components.  See vtkDataObject for details.
		/// </summary>
		// Token: 0x0601654F RID: 91471 RVA: 0x001F6814 File Offset: 0x001F4A14
		public override void CopyInformationToPipeline(vtkInformation info)
		{
			vtkImageStencilData.vtkImageStencilData_CopyInformationToPipeline_05(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06016550 RID: 91472
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_DeepCopy_06(HandleRef pThis, HandleRef o);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016551 RID: 91473 RVA: 0x001F6844 File Offset: 0x001F4A44
		public override void DeepCopy(vtkDataObject o)
		{
			vtkImageStencilData.vtkImageStencilData_DeepCopy_06(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		// Token: 0x06016552 RID: 91474
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_Fill_07(HandleRef pThis);

		/// <summary>
		/// Fill the sub-extents.
		/// </summary>
		// Token: 0x06016553 RID: 91475 RVA: 0x001F6873 File Offset: 0x001F4A73
		public void Fill()
		{
			vtkImageStencilData.vtkImageStencilData_Fill_07(base.GetCppThis());
		}

		// Token: 0x06016554 RID: 91476
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_GetData_08(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x06016555 RID: 91477 RVA: 0x001F6884 File Offset: 0x001F4A84
		public new static vtkImageStencilData GetData(vtkInformation info)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetData_08((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x06016556 RID: 91478
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_GetData_09(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x06016557 RID: 91479 RVA: 0x001F6904 File Offset: 0x001F4B04
		public new static vtkImageStencilData GetData(vtkInformationVector v, int i)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetData_09((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x06016558 RID: 91480
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_GetDataObjectType_10(HandleRef pThis);

		/// <summary>
		/// Returns `VTK_IMAGE_STENCIL_DATA`.
		/// </summary>
		// Token: 0x06016559 RID: 91481 RVA: 0x001F6984 File Offset: 0x001F4B84
		public override int GetDataObjectType()
		{
			return vtkImageStencilData.vtkImageStencilData_GetDataObjectType_10(base.GetCppThis());
		}

		// Token: 0x0601655A RID: 91482
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_GetExtent_11(HandleRef pThis);

		/// <summary>
		/// Set the extent of the data.  This is should be called only
		/// by vtkImageStencilSource, as it is part of the basic pipeline
		/// functionality.
		/// </summary>
		// Token: 0x0601655B RID: 91483 RVA: 0x001F69A4 File Offset: 0x001F4BA4
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601655C RID: 91484
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the extent of the data.  This is should be called only
		/// by vtkImageStencilSource, as it is part of the basic pipeline
		/// functionality.
		/// </summary>
		// Token: 0x0601655D RID: 91485 RVA: 0x001F69EC File Offset: 0x001F4BEC
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageStencilData.vtkImageStencilData_GetExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601655E RID: 91486
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetExtent_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the extent of the data.  This is should be called only
		/// by vtkImageStencilSource, as it is part of the basic pipeline
		/// functionality.
		/// </summary>
		// Token: 0x0601655F RID: 91487 RVA: 0x001F6A04 File Offset: 0x001F4C04
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetExtent_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06016560 RID: 91488
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_GetExtentType_14(HandleRef pThis);

		/// <summary>
		/// The extent type is 3D, just like vtkImageData.
		/// </summary>
		// Token: 0x06016561 RID: 91489 RVA: 0x001F6A14 File Offset: 0x001F4C14
		public override int GetExtentType()
		{
			return vtkImageStencilData.vtkImageStencilData_GetExtentType_14(base.GetCppThis());
		}

		// Token: 0x06016562 RID: 91490
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_GetNextExtent_15(HandleRef pThis, ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter);

		/// <summary>
		/// Given the total output x extent [xMin,xMax] and the current y, z indices,
		/// return each sub-extent [r1,r2] that lies within within the unclipped
		/// region in sequence.  A value of '0' is returned if no more sub-extents
		/// are available.  The variable 'iter' must be initialized to zero before
		/// the first call, unless you want the complementary sub-extents in which
		/// case you must initialize 'iter' to -1.  The variable 'iter' is used
		/// internally to keep track of which sub-extent should be returned next.
		/// </summary>
		// Token: 0x06016563 RID: 91491 RVA: 0x001F6A34 File Offset: 0x001F4C34
		public int GetNextExtent(ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter)
		{
			return vtkImageStencilData.vtkImageStencilData_GetNextExtent_15(base.GetCppThis(), ref r1, ref r2, xMin, xMax, yIdx, zIdx, ref iter);
		}

		// Token: 0x06016564 RID: 91492
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilData_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016565 RID: 91493 RVA: 0x001F6A60 File Offset: 0x001F4C60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06016566 RID: 91494
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilData_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016567 RID: 91495 RVA: 0x001F6A80 File Offset: 0x001F4C80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06016568 RID: 91496
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_GetOrigin_18(HandleRef pThis);

		/// <summary>
		/// Set the desired origin for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016569 RID: 91497 RVA: 0x001F6A9C File Offset: 0x001F4C9C
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetOrigin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601656A RID: 91498
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetOrigin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the desired origin for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x0601656B RID: 91499 RVA: 0x001F6AE4 File Offset: 0x001F4CE4
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_GetOrigin_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601656C RID: 91500
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetOrigin_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the desired origin for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x0601656D RID: 91501 RVA: 0x001F6AF6 File Offset: 0x001F4CF6
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetOrigin_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601656E RID: 91502
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_GetSpacing_21(HandleRef pThis);

		/// <summary>
		/// Set the desired spacing for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x0601656F RID: 91503 RVA: 0x001F6B08 File Offset: 0x001F4D08
		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetSpacing_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016570 RID: 91504
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetSpacing_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the desired spacing for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016571 RID: 91505 RVA: 0x001F6B50 File Offset: 0x001F4D50
		public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_GetSpacing_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016572 RID: 91506
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_GetSpacing_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the desired spacing for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016573 RID: 91507 RVA: 0x001F6B62 File Offset: 0x001F4D62
		public virtual void GetSpacing(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetSpacing_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06016574 RID: 91508
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_Initialize_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016575 RID: 91509 RVA: 0x001F6B72 File Offset: 0x001F4D72
		public override void Initialize()
		{
			vtkImageStencilData.vtkImageStencilData_Initialize_24(base.GetCppThis());
		}

		// Token: 0x06016576 RID: 91510
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_InsertAndMergeExtent_25(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		/// <summary>
		/// Similar to InsertNextExtent, except that the extent (r1,r2) at yIdx,
		/// zIdx is merged with other extents, (if any) on that row. So a
		/// unique extent may not necessarily be added. For instance, if an extent
		/// [5,11] already exists adding an extent, [7,9] will not affect the
		/// stencil. Likewise adding [10, 13] will replace the existing extent
		/// with [5,13].
		/// </summary>
		// Token: 0x06016577 RID: 91511 RVA: 0x001F6B81 File Offset: 0x001F4D81
		public void InsertAndMergeExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_InsertAndMergeExtent_25(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		// Token: 0x06016578 RID: 91512
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_InsertNextExtent_26(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		/// <summary>
		/// This method is used by vtkImageStencilDataSource to add an x
		/// sub extent [r1,r2] for the x row (yIdx,zIdx).  The specified sub
		/// extent must not intersect any other sub extents along the same x row.
		/// As well, r1 and r2 must both be within the total x extent
		/// [Extent[0],Extent[1]].
		/// </summary>
		// Token: 0x06016579 RID: 91513 RVA: 0x001F6B95 File Offset: 0x001F4D95
		public void InsertNextExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_InsertNextExtent_26(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		// Token: 0x0601657A RID: 91514
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_InternalImageStencilDataCopy_27(HandleRef pThis, HandleRef s);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601657B RID: 91515 RVA: 0x001F6BAC File Offset: 0x001F4DAC
		public void InternalImageStencilDataCopy(vtkImageStencilData s)
		{
			vtkImageStencilData.vtkImageStencilData_InternalImageStencilDataCopy_27(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0601657C RID: 91516
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601657D RID: 91517 RVA: 0x001F6BDC File Offset: 0x001F4DDC
		public override int IsA(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601657E RID: 91518
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_IsInside_29(HandleRef pThis, int xIdx, int yIdx, int zIdx);

		/// <summary>
		/// Checks if an image index is inside the stencil.
		/// Even though GetNextExtent and the vtkImageStencilIterator are faster
		/// if every voxel in the volume has to be checked, IsInside provides an
		/// efficient alternative for if just a single voxel has to be checked.
		/// </summary>
		// Token: 0x0601657F RID: 91519 RVA: 0x001F6BFC File Offset: 0x001F4DFC
		public int IsInside(int xIdx, int yIdx, int zIdx)
		{
			return vtkImageStencilData.vtkImageStencilData_IsInside_29(base.GetCppThis(), xIdx, yIdx, zIdx);
		}

		// Token: 0x06016580 RID: 91520
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilData_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016581 RID: 91521 RVA: 0x001F6C20 File Offset: 0x001F4E20
		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_IsTypeOf_30(type);
		}

		// Token: 0x06016582 RID: 91522
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016583 RID: 91523 RVA: 0x001F6C3C File Offset: 0x001F4E3C
		public new vtkImageStencilData NewInstance()
		{
			vtkImageStencilData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016584 RID: 91524
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_RemoveExtent_33(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		/// <summary>
		/// Remove the extent from (r1,r2) at yIdx, zIdx
		/// </summary>
		// Token: 0x06016585 RID: 91525 RVA: 0x001F6C96 File Offset: 0x001F4E96
		public void RemoveExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_RemoveExtent_33(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		// Token: 0x06016586 RID: 91526
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_Replace_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Replaces the portion of the stencil, supplied as argument,
		/// that lies within Self from Self.
		/// </summary>
		// Token: 0x06016587 RID: 91527 RVA: 0x001F6CAC File Offset: 0x001F4EAC
		public virtual void Replace(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Replace_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016588 RID: 91528
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilData_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016589 RID: 91529 RVA: 0x001F6CDC File Offset: 0x001F4EDC
		public new static vtkImageStencilData SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x0601658A RID: 91530
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetExtent_36(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set the extent of the data.  This is should be called only
		/// by vtkImageStencilSource, as it is part of the basic pipeline
		/// functionality.
		/// </summary>
		// Token: 0x0601658B RID: 91531 RVA: 0x001F6D5B File Offset: 0x001F4F5B
		public void SetExtent(IntPtr extent)
		{
			vtkImageStencilData.vtkImageStencilData_SetExtent_36(base.GetCppThis(), extent);
		}

		// Token: 0x0601658C RID: 91532
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetExtent_37(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		/// <summary>
		/// Set the extent of the data.  This is should be called only
		/// by vtkImageStencilSource, as it is part of the basic pipeline
		/// functionality.
		/// </summary>
		// Token: 0x0601658D RID: 91533 RVA: 0x001F6D6B File Offset: 0x001F4F6B
		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageStencilData.vtkImageStencilData_SetExtent_37(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		// Token: 0x0601658E RID: 91534
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetOrigin_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the desired origin for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x0601658F RID: 91535 RVA: 0x001F6D83 File Offset: 0x001F4F83
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_SetOrigin_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016590 RID: 91536
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetOrigin_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the desired origin for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016591 RID: 91537 RVA: 0x001F6D95 File Offset: 0x001F4F95
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_SetOrigin_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06016592 RID: 91538
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetSpacing_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the desired spacing for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016593 RID: 91539 RVA: 0x001F6DA5 File Offset: 0x001F4FA5
		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_SetSpacing_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016594 RID: 91540
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_SetSpacing_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the desired spacing for the stencil.
		/// This must be called before the stencil is Updated, ideally
		/// in the ExecuteInformation method of the imaging filter that
		/// is using the stencil.
		/// </summary>
		// Token: 0x06016595 RID: 91541 RVA: 0x001F6DB7 File Offset: 0x001F4FB7
		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_SetSpacing_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06016596 RID: 91542
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_ShallowCopy_42(HandleRef pThis, HandleRef f);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016597 RID: 91543 RVA: 0x001F6DC8 File Offset: 0x001F4FC8
		public override void ShallowCopy(vtkDataObject f)
		{
			vtkImageStencilData.vtkImageStencilData_ShallowCopy_42(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x06016598 RID: 91544
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilData_Subtract_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Subtract removes the portion of the stencil, supplied as argument,
		/// that lies within Self from Self.
		/// </summary>
		// Token: 0x06016599 RID: 91545 RVA: 0x001F6DF8 File Offset: 0x001F4FF8
		public virtual void Subtract(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Subtract_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001926 RID: 6438
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001927 RID: 6439
		public new static readonly string MRClassNameKey = "class vtkImageStencilData";
	}
}
