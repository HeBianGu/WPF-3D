using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractImageInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate data values from images
	///
	/// vtkAbstractImageInterpolator provides an abstract interface for
	/// interpolating image data.  You specify the data set you want to
	/// interpolate values from, then call Interpolate(x,y,z) to interpolate
	/// the data.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReslice vtkImageInterpolator vtkImageSincInterpolator
	/// </seealso>
	// Token: 0x02000848 RID: 2120
	public abstract class vtkAbstractImageInterpolator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015FB4 RID: 90036 RVA: 0x001EF60F File Offset: 0x001ED80F
		static vtkAbstractImageInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractImageInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractImageInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015FB5 RID: 90037 RVA: 0x001EF637 File Offset: 0x001ED837
		public vtkAbstractImageInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015FB6 RID: 90038 RVA: 0x001EF645 File Offset: 0x001ED845
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015FB7 RID: 90039
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractImageInterpolator_CheckBoundsIJK_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Check an x,y,z point to see if it is within the bounds for the
		/// structured coords of the image.  This is meant to be called prior
		/// to InterpolateIJK.  The bounds that are checked against are the input
		/// image extent plus the tolerance.
		/// </summary>
		// Token: 0x06015FB8 RID: 90040 RVA: 0x001EF650 File Offset: 0x001ED850
		public bool CheckBoundsIJK(IntPtr x)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_CheckBoundsIJK_01(base.GetCppThis(), x) != 0;
		}

		// Token: 0x06015FB9 RID: 90041
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_ComputeNumberOfComponents_02(HandleRef pThis, int inputComponents);

		/// <summary>
		/// Compute the number of output components based on the ComponentOffset,
		/// ComponentCount, and the number of components in the input data.
		/// </summary>
		// Token: 0x06015FBA RID: 90042 RVA: 0x001EF678 File Offset: 0x001ED878
		public int ComputeNumberOfComponents(int inputComponents)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_ComputeNumberOfComponents_02(base.GetCppThis(), inputComponents);
		}

		// Token: 0x06015FBB RID: 90043
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_ComputeSupportSize_03(HandleRef pThis, IntPtr matrix, IntPtr support);

		/// <summary>
		/// Get the support size for use in computing update extents.  If the data
		/// will be sampled on a regular grid, then pass a matrix describing the
		/// structured coordinate transformation between the output and the input.
		/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
		/// </summary>
		// Token: 0x06015FBC RID: 90044 RVA: 0x001EF698 File Offset: 0x001ED898
		public virtual void ComputeSupportSize(IntPtr matrix, IntPtr support)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_ComputeSupportSize_03(base.GetCppThis(), matrix, support);
		}

		// Token: 0x06015FBD RID: 90045
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_DeepCopy_04(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Copy the interpolator.  It is possible to duplicate an interpolator
		/// by calling NewInstance() followed by DeepCopy().
		/// </summary>
		// Token: 0x06015FBE RID: 90046 RVA: 0x001EF6AC File Offset: 0x001ED8AC
		public void DeepCopy(vtkAbstractImageInterpolator obj)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_DeepCopy_04(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06015FBF RID: 90047
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageBorderMode vtkAbstractImageInterpolator_GetBorderMode_05(HandleRef pThis);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06015FC0 RID: 90048 RVA: 0x001EF6DC File Offset: 0x001ED8DC
		public vtkImageBorderMode GetBorderMode()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetBorderMode_05(base.GetCppThis());
		}

		// Token: 0x06015FC1 RID: 90049
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_GetBorderModeAsString_06(HandleRef pThis);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06015FC2 RID: 90050 RVA: 0x001EF6FC File Offset: 0x001ED8FC
		public string GetBorderModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetBorderModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015FC3 RID: 90051
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_GetComponentCount_07(HandleRef pThis);

		/// <summary>
		/// This method specifies the number of components to extract.  The default
		/// value is -1, which extracts all available components.  When the
		/// interpolation is performed, this will be clamped to the number of
		/// available components.
		/// </summary>
		// Token: 0x06015FC4 RID: 90052 RVA: 0x001EF738 File Offset: 0x001ED938
		public int GetComponentCount()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetComponentCount_07(base.GetCppThis());
		}

		// Token: 0x06015FC5 RID: 90053
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_GetComponentOffset_08(HandleRef pThis);

		/// <summary>
		/// This method specifies which component of the input will be interpolated,
		/// or if ComponentCount is also set, it specifies the first component.
		/// When the interpolation is performed, it will be clamped to the number
		/// of available components.
		/// </summary>
		// Token: 0x06015FC6 RID: 90054 RVA: 0x001EF758 File Offset: 0x001ED958
		public int GetComponentOffset()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetComponentOffset_08(base.GetCppThis());
		}

		// Token: 0x06015FC7 RID: 90055
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_GetDirection_09(HandleRef pThis);

		/// <summary>
		/// Get the direction of the data being interpolated.
		/// </summary>
		// Token: 0x06015FC8 RID: 90056 RVA: 0x001EF778 File Offset: 0x001ED978
		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetDirection_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015FC9 RID: 90057
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetDirection_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the direction of the data being interpolated.
		/// </summary>
		// Token: 0x06015FCA RID: 90058 RVA: 0x001EF7C1 File Offset: 0x001ED9C1
		public virtual void GetDirection(IntPtr data)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetDirection_10(base.GetCppThis(), data);
		}

		// Token: 0x06015FCB RID: 90059
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_GetExtent_11(HandleRef pThis);

		/// <summary>
		/// Get the extent of the data being interpolated.
		/// </summary>
		// Token: 0x06015FCC RID: 90060 RVA: 0x001EF7D4 File Offset: 0x001ED9D4
		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015FCD RID: 90061
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get the extent of the data being interpolated.
		/// </summary>
		// Token: 0x06015FCE RID: 90062 RVA: 0x001EF81C File Offset: 0x001EDA1C
		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06015FCF RID: 90063
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetExtent_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the extent of the data being interpolated.
		/// </summary>
		// Token: 0x06015FD0 RID: 90064 RVA: 0x001EF834 File Offset: 0x001EDA34
		public virtual void GetExtent(IntPtr _arg)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetExtent_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FD1 RID: 90065
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_GetNumberOfComponents_14(HandleRef pThis);

		/// <summary>
		/// Get the number of components that will be returned when Interpolate()
		/// is called.  This is only valid after initialization.  Before then, use
		/// ComputeNumberOfComponents instead.
		/// </summary>
		// Token: 0x06015FD2 RID: 90066 RVA: 0x001EF844 File Offset: 0x001EDA44
		public int GetNumberOfComponents()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetNumberOfComponents_14(base.GetCppThis());
		}

		// Token: 0x06015FD3 RID: 90067
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FD4 RID: 90068 RVA: 0x001EF864 File Offset: 0x001EDA64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06015FD5 RID: 90069
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FD6 RID: 90070 RVA: 0x001EF884 File Offset: 0x001EDA84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06015FD7 RID: 90071
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_GetOrigin_17(HandleRef pThis);

		/// <summary>
		/// Get the origin of the data being interpolated.
		/// </summary>
		// Token: 0x06015FD8 RID: 90072 RVA: 0x001EF8A0 File Offset: 0x001EDAA0
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetOrigin_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015FD9 RID: 90073
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetOrigin_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the origin of the data being interpolated.
		/// </summary>
		// Token: 0x06015FDA RID: 90074 RVA: 0x001EF8E8 File Offset: 0x001EDAE8
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetOrigin_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06015FDB RID: 90075
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetOrigin_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the origin of the data being interpolated.
		/// </summary>
		// Token: 0x06015FDC RID: 90076 RVA: 0x001EF8FA File Offset: 0x001EDAFA
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetOrigin_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FDD RID: 90077
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractImageInterpolator_GetOutValue_20(HandleRef pThis);

		/// <summary>
		/// The value to return when the point is out of bounds.
		/// </summary>
		// Token: 0x06015FDE RID: 90078 RVA: 0x001EF90C File Offset: 0x001EDB0C
		public double GetOutValue()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetOutValue_20(base.GetCppThis());
		}

		// Token: 0x06015FDF RID: 90079
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractImageInterpolator_GetSlidingWindow_21(HandleRef pThis);

		/// <summary>
		/// Enable sliding window for separable kernels.
		/// When this is enabled, the interpolator will cache partial sums in
		/// in order to accelerate the computation.  It only makes sense to do
		/// this if the interpolator is used by calling InterpolateRow() while
		/// incrementing first the Y, and then the Z index with every call.
		/// </summary>
		// Token: 0x06015FE0 RID: 90080 RVA: 0x001EF92C File Offset: 0x001EDB2C
		public bool GetSlidingWindow()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetSlidingWindow_21(base.GetCppThis()) != 0;
		}

		// Token: 0x06015FE1 RID: 90081
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_GetSpacing_22(HandleRef pThis);

		/// <summary>
		/// Get the spacing of the data being interpolated.
		/// </summary>
		// Token: 0x06015FE2 RID: 90082 RVA: 0x001EF954 File Offset: 0x001EDB54
		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetSpacing_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015FE3 RID: 90083
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetSpacing_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the spacing of the data being interpolated.
		/// </summary>
		// Token: 0x06015FE4 RID: 90084 RVA: 0x001EF99C File Offset: 0x001EDB9C
		public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetSpacing_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06015FE5 RID: 90085
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_GetSpacing_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the spacing of the data being interpolated.
		/// </summary>
		// Token: 0x06015FE6 RID: 90086 RVA: 0x001EF9AE File Offset: 0x001EDBAE
		public virtual void GetSpacing(IntPtr _arg)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetSpacing_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06015FE7 RID: 90087
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractImageInterpolator_GetTolerance_25(HandleRef pThis);

		/// <summary>
		/// The tolerance to apply when checking whether a point is out of bounds.
		/// This is a fractional distance relative to the voxel size, so a tolerance
		/// of 1 expands the bounds by one voxel.
		/// </summary>
		// Token: 0x06015FE8 RID: 90088 RVA: 0x001EF9C0 File Offset: 0x001EDBC0
		public double GetTolerance()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_GetTolerance_25(base.GetCppThis());
		}

		// Token: 0x06015FE9 RID: 90089
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_Initialize_26(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Initialize the interpolator with the data that you wish to interpolate.
		/// </summary>
		// Token: 0x06015FEA RID: 90090 RVA: 0x001EF9E0 File Offset: 0x001EDBE0
		public virtual void Initialize(vtkDataObject data)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_Initialize_26(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x06015FEB RID: 90091
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractImageInterpolator_Interpolate_27(HandleRef pThis, double x, double y, double z, int component);

		/// <summary>
		/// Get the result of interpolating the specified component of the input
		/// data, which should be set to zero if there is only one component.
		/// If the point is not within the bounds of the data set, then OutValue
		/// will be returned.  This method is primarily meant for use by the
		/// wrapper languages.
		/// </summary>
		// Token: 0x06015FEC RID: 90092 RVA: 0x001EFA10 File Offset: 0x001EDC10
		public double Interpolate(double x, double y, double z, int component)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_Interpolate_27(base.GetCppThis(), x, y, z, component);
		}

		// Token: 0x06015FED RID: 90093
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractImageInterpolator_Interpolate_28(HandleRef pThis, IntPtr point, IntPtr value);

		/// <summary>
		/// Sample the input data. This is an inline method that calls the
		/// function that performs the appropriate interpolation for the
		/// data type.  If the point is not within the bounds of the data set,
		/// then the return value is false, and each component will be set to
		/// the OutValue.
		/// </summary>
		// Token: 0x06015FEE RID: 90094 RVA: 0x001EFA34 File Offset: 0x001EDC34
		public bool Interpolate(IntPtr point, IntPtr value)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_Interpolate_28(base.GetCppThis(), point, value) != 0;
		}

		// Token: 0x06015FEF RID: 90095
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_InterpolateIJK_29(HandleRef pThis, IntPtr point, IntPtr value);

		/// <summary>
		/// A version of Interpolate that takes structured coords instead of data
		/// coords.  Structured coords are the data coords after subtracting the
		/// Origin and dividing by the Spacing.
		/// </summary>
		// Token: 0x06015FF0 RID: 90096 RVA: 0x001EFA5C File Offset: 0x001EDC5C
		public void InterpolateIJK(IntPtr point, IntPtr value)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_InterpolateIJK_29(base.GetCppThis(), point, value);
		}

		// Token: 0x06015FF1 RID: 90097
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FF2 RID: 90098 RVA: 0x001EFA70 File Offset: 0x001EDC70
		public override int IsA(string type)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x06015FF3 RID: 90099
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractImageInterpolator_IsSeparable_31(HandleRef pThis);

		/// <summary>
		/// True if the interpolation is separable, which means that the weights
		/// can be precomputed in order to accelerate the interpolation.  Any
		/// interpolator which is separable will implement the methods
		/// PrecomputeWeightsForExtent and InterpolateRow
		/// </summary>
		// Token: 0x06015FF4 RID: 90100 RVA: 0x001EFA90 File Offset: 0x001EDC90
		public virtual bool IsSeparable()
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_IsSeparable_31(base.GetCppThis()) != 0;
		}

		// Token: 0x06015FF5 RID: 90101
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractImageInterpolator_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FF6 RID: 90102 RVA: 0x001EFAB8 File Offset: 0x001EDCB8
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_IsTypeOf_32(type);
		}

		// Token: 0x06015FF7 RID: 90103
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FF8 RID: 90104 RVA: 0x001EFAD4 File Offset: 0x001EDCD4
		public new vtkAbstractImageInterpolator NewInstance()
		{
			vtkAbstractImageInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015FF9 RID: 90105
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_ReleaseData_34(HandleRef pThis);

		/// <summary>
		/// Release any data stored by the interpolator.
		/// </summary>
		// Token: 0x06015FFA RID: 90106 RVA: 0x001EFB2E File Offset: 0x001EDD2E
		public virtual void ReleaseData()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_ReleaseData_34(base.GetCppThis());
		}

		// Token: 0x06015FFB RID: 90107
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractImageInterpolator_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015FFC RID: 90108 RVA: 0x001EFB40 File Offset: 0x001EDD40
		public new static vtkAbstractImageInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractImageInterpolator vtkAbstractImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractImageInterpolator = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractImageInterpolator.Register(null);
				}
			}
			return vtkAbstractImageInterpolator;
		}

		// Token: 0x06015FFD RID: 90109
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetBorderMode_36(HandleRef pThis, vtkImageBorderMode mode);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06015FFE RID: 90110 RVA: 0x001EFBBF File Offset: 0x001EDDBF
		public void SetBorderMode(vtkImageBorderMode mode)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetBorderMode_36(base.GetCppThis(), mode);
		}

		// Token: 0x06015FFF RID: 90111
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetBorderModeToClamp_37(HandleRef pThis);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06016000 RID: 90112 RVA: 0x001EFBCF File Offset: 0x001EDDCF
		public void SetBorderModeToClamp()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetBorderModeToClamp_37(base.GetCppThis());
		}

		// Token: 0x06016001 RID: 90113
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetBorderModeToMirror_38(HandleRef pThis);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06016002 RID: 90114 RVA: 0x001EFBDE File Offset: 0x001EDDDE
		public void SetBorderModeToMirror()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetBorderModeToMirror_38(base.GetCppThis());
		}

		// Token: 0x06016003 RID: 90115
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetBorderModeToRepeat_39(HandleRef pThis);

		/// <summary>
		/// The border mode (default: clamp).  This controls how out-of-bounds
		/// lookups are handled, i.e. how data will be extrapolated beyond the
		/// bounds of the image.  The default is to clamp the lookup point to the
		/// bounds.  The other modes wrap around to the opposite boundary, or
		/// mirror the image at the boundary.
		/// </summary>
		// Token: 0x06016004 RID: 90116 RVA: 0x001EFBED File Offset: 0x001EDDED
		public void SetBorderModeToRepeat()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetBorderModeToRepeat_39(base.GetCppThis());
		}

		// Token: 0x06016005 RID: 90117
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetComponentCount_40(HandleRef pThis, int count);

		/// <summary>
		/// This method specifies the number of components to extract.  The default
		/// value is -1, which extracts all available components.  When the
		/// interpolation is performed, this will be clamped to the number of
		/// available components.
		/// </summary>
		// Token: 0x06016006 RID: 90118 RVA: 0x001EFBFC File Offset: 0x001EDDFC
		public void SetComponentCount(int count)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetComponentCount_40(base.GetCppThis(), count);
		}

		// Token: 0x06016007 RID: 90119
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetComponentOffset_41(HandleRef pThis, int offset);

		/// <summary>
		/// This method specifies which component of the input will be interpolated,
		/// or if ComponentCount is also set, it specifies the first component.
		/// When the interpolation is performed, it will be clamped to the number
		/// of available components.
		/// </summary>
		// Token: 0x06016008 RID: 90120 RVA: 0x001EFC0C File Offset: 0x001EDE0C
		public void SetComponentOffset(int offset)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetComponentOffset_41(base.GetCppThis(), offset);
		}

		// Token: 0x06016009 RID: 90121
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetOutValue_42(HandleRef pThis, double outValue);

		/// <summary>
		/// The value to return when the point is out of bounds.
		/// </summary>
		// Token: 0x0601600A RID: 90122 RVA: 0x001EFC1C File Offset: 0x001EDE1C
		public void SetOutValue(double outValue)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetOutValue_42(base.GetCppThis(), outValue);
		}

		// Token: 0x0601600B RID: 90123
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetSlidingWindow_43(HandleRef pThis, byte x);

		/// <summary>
		/// Enable sliding window for separable kernels.
		/// When this is enabled, the interpolator will cache partial sums in
		/// in order to accelerate the computation.  It only makes sense to do
		/// this if the interpolator is used by calling InterpolateRow() while
		/// incrementing first the Y, and then the Z index with every call.
		/// </summary>
		// Token: 0x0601600C RID: 90124 RVA: 0x001EFC2C File Offset: 0x001EDE2C
		public void SetSlidingWindow(bool x)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetSlidingWindow_43(base.GetCppThis(), x ? (byte)1 : (byte)0);
		}

		// Token: 0x0601600D RID: 90125
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SetTolerance_44(HandleRef pThis, double tol);

		/// <summary>
		/// The tolerance to apply when checking whether a point is out of bounds.
		/// This is a fractional distance relative to the voxel size, so a tolerance
		/// of 1 expands the bounds by one voxel.
		/// </summary>
		// Token: 0x0601600E RID: 90126 RVA: 0x001EFC44 File Offset: 0x001EDE44
		public void SetTolerance(double tol)
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SetTolerance_44(base.GetCppThis(), tol);
		}

		// Token: 0x0601600F RID: 90127
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SlidingWindowOff_45(HandleRef pThis);

		/// <summary>
		/// Enable sliding window for separable kernels.
		/// When this is enabled, the interpolator will cache partial sums in
		/// in order to accelerate the computation.  It only makes sense to do
		/// this if the interpolator is used by calling InterpolateRow() while
		/// incrementing first the Y, and then the Z index with every call.
		/// </summary>
		// Token: 0x06016010 RID: 90128 RVA: 0x001EFC54 File Offset: 0x001EDE54
		public void SlidingWindowOff()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SlidingWindowOff_45(base.GetCppThis());
		}

		// Token: 0x06016011 RID: 90129
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_SlidingWindowOn_46(HandleRef pThis);

		/// <summary>
		/// Enable sliding window for separable kernels.
		/// When this is enabled, the interpolator will cache partial sums in
		/// in order to accelerate the computation.  It only makes sense to do
		/// this if the interpolator is used by calling InterpolateRow() while
		/// incrementing first the Y, and then the Z index with every call.
		/// </summary>
		// Token: 0x06016012 RID: 90130 RVA: 0x001EFC63 File Offset: 0x001EDE63
		public void SlidingWindowOn()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_SlidingWindowOn_46(base.GetCppThis());
		}

		// Token: 0x06016013 RID: 90131
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractImageInterpolator_Update_47(HandleRef pThis);

		/// <summary>
		/// Update the interpolator.  If the interpolator has been modified by
		/// a Set method since Initialize() was called, you must call this method
		/// to update the interpolator before you can use it.
		/// </summary>
		// Token: 0x06016014 RID: 90132 RVA: 0x001EFC72 File Offset: 0x001EDE72
		public virtual void Update()
		{
			vtkAbstractImageInterpolator.vtkAbstractImageInterpolator_Update_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E4 RID: 6372
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractImageInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018E5 RID: 6373
		public new static readonly string MRClassNameKey = "class vtkAbstractImageInterpolator";
	}
}
