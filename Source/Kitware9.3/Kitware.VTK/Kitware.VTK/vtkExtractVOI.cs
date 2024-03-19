using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractVOI
	/// </summary>
	/// <remarks>
	///    select piece (e.g., volume of interest) and/or subsample structured points dataset
	///
	///
	/// vtkExtractVOI is a filter that selects a portion of an input structured
	/// points dataset, or subsamples an input dataset. (The selected portion of
	/// interested is referred to as the Volume Of Interest, or VOI.) The output of
	/// this filter is a structured points dataset. The filter treats input data
	/// of any topological dimension (i.e., point, line, image, or volume) and can
	/// generate output data of any topological dimension.
	///
	/// To use this filter set the VOI ivar which are i-j-k min/max indices that
	/// specify a rectangular region in the data. (Note that these are 0-offset.)
	/// You can also specify a sampling rate to subsample the data.
	///
	/// Typical applications of this filter are to extract a slice from a volume
	/// for image processing, subsampling large volumes to reduce data size, or
	/// extracting regions of a volume with interesting data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeometryFilter vtkExtractGeometry vtkExtractGrid
	/// </seealso>
	// Token: 0x02000849 RID: 2121
	public class vtkExtractVOI : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016015 RID: 90133 RVA: 0x001EFC81 File Offset: 0x001EDE81
		static vtkExtractVOI()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractVOI.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVOI"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016016 RID: 90134 RVA: 0x001EFCA9 File Offset: 0x001EDEA9
		public vtkExtractVOI(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016017 RID: 90135
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVOI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object to extract all of the input data.
		/// </summary>
		// Token: 0x06016018 RID: 90136 RVA: 0x001EFCB8 File Offset: 0x001EDEB8
		public new static vtkExtractVOI New()
		{
			vtkExtractVOI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object to extract all of the input data.
		/// </summary>
		// Token: 0x06016019 RID: 90137 RVA: 0x001EFD0C File Offset: 0x001EDF0C
		public vtkExtractVOI() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractVOI.vtkExtractVOI_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601601A RID: 90138 RVA: 0x001EFD50 File Offset: 0x001EDF50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601601B RID: 90139
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVOI_GetIncludeBoundary_01(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x0601601C RID: 90140 RVA: 0x001EFD5C File Offset: 0x001EDF5C
		public virtual int GetIncludeBoundary()
		{
			return vtkExtractVOI.vtkExtractVOI_GetIncludeBoundary_01(base.GetCppThis());
		}

		// Token: 0x0601601D RID: 90141
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractVOI_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601601E RID: 90142 RVA: 0x001EFD7C File Offset: 0x001EDF7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601601F RID: 90143
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractVOI_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016020 RID: 90144 RVA: 0x001EFD9C File Offset: 0x001EDF9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016021 RID: 90145
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVOI_GetSampleRate_04(HandleRef pThis);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
		/// 1, then the resulting VOI will be subsampled representation of the
		/// input.  For example, if the SampleRate=(2,2,2), every other point will
		/// be selected, resulting in a volume 1/8th the original size.
		/// </summary>
		// Token: 0x06016022 RID: 90146 RVA: 0x001EFDB8 File Offset: 0x001EDFB8
		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_GetSampleRate_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016023 RID: 90147
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_GetSampleRate_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
		/// 1, then the resulting VOI will be subsampled representation of the
		/// input.  For example, if the SampleRate=(2,2,2), every other point will
		/// be selected, resulting in a volume 1/8th the original size.
		/// </summary>
		// Token: 0x06016024 RID: 90148 RVA: 0x001EFE00 File Offset: 0x001EE000
		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractVOI.vtkExtractVOI_GetSampleRate_05(base.GetCppThis(), data);
		}

		// Token: 0x06016025 RID: 90149
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVOI_GetVOI_06(HandleRef pThis);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
		/// dataset can be of any topological dimension (i.e., point, line, image,
		/// or volume).
		/// </summary>
		// Token: 0x06016026 RID: 90150 RVA: 0x001EFE10 File Offset: 0x001EE010
		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_GetVOI_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016027 RID: 90151
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_GetVOI_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
		/// dataset can be of any topological dimension (i.e., point, line, image,
		/// or volume).
		/// </summary>
		// Token: 0x06016028 RID: 90152 RVA: 0x001EFE58 File Offset: 0x001EE058
		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractVOI.vtkExtractVOI_GetVOI_07(base.GetCppThis(), data);
		}

		// Token: 0x06016029 RID: 90153
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_IncludeBoundaryOff_08(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x0601602A RID: 90154 RVA: 0x001EFE68 File Offset: 0x001EE068
		public virtual void IncludeBoundaryOff()
		{
			vtkExtractVOI.vtkExtractVOI_IncludeBoundaryOff_08(base.GetCppThis());
		}

		// Token: 0x0601602B RID: 90155
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_IncludeBoundaryOn_09(HandleRef pThis);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x0601602C RID: 90156 RVA: 0x001EFE77 File Offset: 0x001EE077
		public virtual void IncludeBoundaryOn()
		{
			vtkExtractVOI.vtkExtractVOI_IncludeBoundaryOn_09(base.GetCppThis());
		}

		// Token: 0x0601602D RID: 90157
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVOI_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601602E RID: 90158 RVA: 0x001EFE88 File Offset: 0x001EE088
		public override int IsA(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601602F RID: 90159
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractVOI_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016030 RID: 90160 RVA: 0x001EFEA8 File Offset: 0x001EE0A8
		public new static int IsTypeOf(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_IsTypeOf_11(type);
		}

		// Token: 0x06016031 RID: 90161
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVOI_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016032 RID: 90162 RVA: 0x001EFEC4 File Offset: 0x001EE0C4
		public new vtkExtractVOI NewInstance()
		{
			vtkExtractVOI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016033 RID: 90163
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractVOI_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016034 RID: 90164 RVA: 0x001EFF20 File Offset: 0x001EE120
		public new static vtkExtractVOI SafeDownCast(vtkObjectBase o)
		{
			vtkExtractVOI vtkExtractVOI = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractVOI = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractVOI.Register(null);
				}
			}
			return vtkExtractVOI;
		}

		// Token: 0x06016035 RID: 90165
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_SetIncludeBoundary_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether to enforce that the "boundary" of the grid is output in
		/// the subsampling process. (This ivar only has effect when the SampleRate
		/// in any direction is not equal to 1.) When this ivar IncludeBoundary is
		/// on, the subsampling will always include the boundary of the grid even
		/// though the sample rate is not an even multiple of the grid
		/// dimensions. (By default IncludeBoundary is off.)
		/// </summary>
		// Token: 0x06016036 RID: 90166 RVA: 0x001EFF9F File Offset: 0x001EE19F
		public virtual void SetIncludeBoundary(int _arg)
		{
			vtkExtractVOI.vtkExtractVOI_SetIncludeBoundary_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06016037 RID: 90167
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_SetSampleRate_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
		/// 1, then the resulting VOI will be subsampled representation of the
		/// input.  For example, if the SampleRate=(2,2,2), every other point will
		/// be selected, resulting in a volume 1/8th the original size.
		/// </summary>
		// Token: 0x06016038 RID: 90168 RVA: 0x001EFFAF File Offset: 0x001EE1AF
		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractVOI.vtkExtractVOI_SetSampleRate_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016039 RID: 90169
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_SetSampleRate_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the sampling rate in the i, j, and k directions. If the rate is &gt;
		/// 1, then the resulting VOI will be subsampled representation of the
		/// input.  For example, if the SampleRate=(2,2,2), every other point will
		/// be selected, resulting in a volume 1/8th the original size.
		/// </summary>
		// Token: 0x0601603A RID: 90170 RVA: 0x001EFFC1 File Offset: 0x001EE1C1
		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractVOI.vtkExtractVOI_SetSampleRate_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601603B RID: 90171
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_SetVOI_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
		/// dataset can be of any topological dimension (i.e., point, line, image,
		/// or volume).
		/// </summary>
		// Token: 0x0601603C RID: 90172 RVA: 0x001EFFD1 File Offset: 0x001EE1D1
		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractVOI.vtkExtractVOI_SetVOI_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601603D RID: 90173
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractVOI_SetVOI_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify i-j-k (min,max) pairs to extract. The resulting structured points
		/// dataset can be of any topological dimension (i.e., point, line, image,
		/// or volume).
		/// </summary>
		// Token: 0x0601603E RID: 90174 RVA: 0x001EFFE9 File Offset: 0x001EE1E9
		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractVOI.vtkExtractVOI_SetVOI_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E6 RID: 6374
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVOI";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E7 RID: 6375
		public new static readonly string MRClassNameKey = "class vtkExtractVOI";
	}
}
