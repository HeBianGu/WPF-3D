using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStencilSource
	/// </summary>
	/// <remarks>
	///    generate an image stencil
	///
	/// vtkImageStencilSource is a superclass for filters that generate image
	/// stencils.  Given a clipping object such as a vtkImplicitFunction, it
	/// will set up a list of clipping extents for each x-row through the
	/// image data.  The extents for each x-row can be retrieved via the
	/// GetNextExtent() method after the extent lists have been built
	/// with the BuildExtents() method.  For large images, using clipping
	/// extents is much more memory efficient (and slightly more time-efficient)
	/// than building a mask.  This class can be subclassed to allow clipping
	/// with objects other than vtkImplicitFunction.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkImageStencil vtkPolyDataToImageStencil
	/// </seealso>
	// Token: 0x02000238 RID: 568
	public class vtkImageStencilSource : vtkImageStencilAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006A0D RID: 27149 RVA: 0x0009940C File Offset: 0x0009760C
		static vtkImageStencilSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006A0E RID: 27150 RVA: 0x00099434 File Offset: 0x00097634
		public vtkImageStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006A0F RID: 27151
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A10 RID: 27152 RVA: 0x00099444 File Offset: 0x00097644
		public new static vtkImageStencilSource New()
		{
			vtkImageStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A11 RID: 27153 RVA: 0x00099498 File Offset: 0x00097698
		public vtkImageStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStencilSource.vtkImageStencilSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006A12 RID: 27154 RVA: 0x000994DC File Offset: 0x000976DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006A13 RID: 27155
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_GetInformationInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a vtkImageData that has the Spacing, Origin, and
		/// WholeExtent that will be used for the stencil.  This
		/// input should be set to the image that you wish to
		/// apply the stencil to.  If you use this method, then
		/// any values set with the SetOutputSpacing, SetOutputOrigin,
		/// and SetOutputWholeExtent methods will be ignored.
		/// </summary>
		// Token: 0x06006A14 RID: 27156 RVA: 0x000994E8 File Offset: 0x000976E8
		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetInformationInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06006A15 RID: 27157
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A16 RID: 27158 RVA: 0x00099558 File Offset: 0x00097758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006A17 RID: 27159
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencilSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A18 RID: 27160 RVA: 0x00099578 File Offset: 0x00097778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006A19 RID: 27161
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_GetOutputOrigin_04(HandleRef pThis);

		/// <summary>
		/// Set the Origin to be used for the stencil.  It should be
		/// set to the Origin of the image you intend to apply the
		/// stencil to. The default value is (0,0,0).
		/// </summary>
		// Token: 0x06006A1A RID: 27162 RVA: 0x00099594 File Offset: 0x00097794
		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006A1B RID: 27163
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the Origin to be used for the stencil.  It should be
		/// set to the Origin of the image you intend to apply the
		/// stencil to. The default value is (0,0,0).
		/// </summary>
		// Token: 0x06006A1C RID: 27164 RVA: 0x000995DC File Offset: 0x000977DC
		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006A1D RID: 27165
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputOrigin_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Origin to be used for the stencil.  It should be
		/// set to the Origin of the image you intend to apply the
		/// stencil to. The default value is (0,0,0).
		/// </summary>
		// Token: 0x06006A1E RID: 27166 RVA: 0x000995EE File Offset: 0x000977EE
		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A1F RID: 27167
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_GetOutputSpacing_07(HandleRef pThis);

		/// <summary>
		/// Set the Spacing to be used for the stencil. It should be
		/// set to the Spacing of the image you intend to apply the
		/// stencil to. The default value is (1,1,1)
		/// </summary>
		// Token: 0x06006A20 RID: 27168 RVA: 0x00099600 File Offset: 0x00097800
		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006A21 RID: 27169
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputSpacing_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the Spacing to be used for the stencil. It should be
		/// set to the Spacing of the image you intend to apply the
		/// stencil to. The default value is (1,1,1)
		/// </summary>
		// Token: 0x06006A22 RID: 27170 RVA: 0x00099648 File Offset: 0x00097848
		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06006A23 RID: 27171
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputSpacing_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Spacing to be used for the stencil. It should be
		/// set to the Spacing of the image you intend to apply the
		/// stencil to. The default value is (1,1,1)
		/// </summary>
		// Token: 0x06006A24 RID: 27172 RVA: 0x0009965A File Offset: 0x0009785A
		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A25 RID: 27173
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_GetOutputWholeExtent_10(HandleRef pThis);

		/// <summary>
		/// Set the whole extent for the stencil (anything outside
		/// this extent will be considered to be "outside" the stencil).
		/// </summary>
		// Token: 0x06006A26 RID: 27174 RVA: 0x0009966C File Offset: 0x0009786C
		public virtual int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006A27 RID: 27175
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputWholeExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the whole extent for the stencil (anything outside
		/// this extent will be considered to be "outside" the stencil).
		/// </summary>
		// Token: 0x06006A28 RID: 27176 RVA: 0x000996B4 File Offset: 0x000978B4
		public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06006A29 RID: 27177
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_GetOutputWholeExtent_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the whole extent for the stencil (anything outside
		/// this extent will be considered to be "outside" the stencil).
		/// </summary>
		// Token: 0x06006A2A RID: 27178 RVA: 0x000996CC File Offset: 0x000978CC
		public virtual void GetOutputWholeExtent(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A2B RID: 27179
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilSource_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A2C RID: 27180 RVA: 0x000996DC File Offset: 0x000978DC
		public override int IsA(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06006A2D RID: 27181
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencilSource_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A2E RID: 27182 RVA: 0x000996FC File Offset: 0x000978FC
		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_IsTypeOf_14(type);
		}

		// Token: 0x06006A2F RID: 27183
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A30 RID: 27184 RVA: 0x00099718 File Offset: 0x00097918
		public new vtkImageStencilSource NewInstance()
		{
			vtkImageStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006A31 RID: 27185
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_ReportReferences_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Report object referenced by instances of this class.
		/// </summary>
		// Token: 0x06006A32 RID: 27186 RVA: 0x00099774 File Offset: 0x00097974
		public virtual void ReportReferences(vtkGarbageCollector arg0)
		{
			vtkImageStencilSource.vtkImageStencilSource_ReportReferences_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006A33 RID: 27187
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencilSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A34 RID: 27188 RVA: 0x000997A4 File Offset: 0x000979A4
		public new static vtkImageStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilSource vtkImageStencilSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilSource = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilSource.Register(null);
				}
			}
			return vtkImageStencilSource;
		}

		// Token: 0x06006A35 RID: 27189
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetInformationInput_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set a vtkImageData that has the Spacing, Origin, and
		/// WholeExtent that will be used for the stencil.  This
		/// input should be set to the image that you wish to
		/// apply the stencil to.  If you use this method, then
		/// any values set with the SetOutputSpacing, SetOutputOrigin,
		/// and SetOutputWholeExtent methods will be ignored.
		/// </summary>
		// Token: 0x06006A36 RID: 27190 RVA: 0x00099824 File Offset: 0x00097A24
		public virtual void SetInformationInput(vtkImageData arg0)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetInformationInput_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006A37 RID: 27191
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputOrigin_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the Origin to be used for the stencil.  It should be
		/// set to the Origin of the image you intend to apply the
		/// stencil to. The default value is (0,0,0).
		/// </summary>
		// Token: 0x06006A38 RID: 27192 RVA: 0x00099853 File Offset: 0x00097A53
		public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputOrigin_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006A39 RID: 27193
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputOrigin_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Origin to be used for the stencil.  It should be
		/// set to the Origin of the image you intend to apply the
		/// stencil to. The default value is (0,0,0).
		/// </summary>
		// Token: 0x06006A3A RID: 27194 RVA: 0x00099865 File Offset: 0x00097A65
		public virtual void SetOutputOrigin(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputOrigin_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A3B RID: 27195
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputSpacing_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the Spacing to be used for the stencil. It should be
		/// set to the Spacing of the image you intend to apply the
		/// stencil to. The default value is (1,1,1)
		/// </summary>
		// Token: 0x06006A3C RID: 27196 RVA: 0x00099875 File Offset: 0x00097A75
		public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputSpacing_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06006A3D RID: 27197
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputSpacing_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the Spacing to be used for the stencil. It should be
		/// set to the Spacing of the image you intend to apply the
		/// stencil to. The default value is (1,1,1)
		/// </summary>
		// Token: 0x06006A3E RID: 27198 RVA: 0x00099887 File Offset: 0x00097A87
		public virtual void SetOutputSpacing(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputSpacing_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A3F RID: 27199
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputWholeExtent_24(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the whole extent for the stencil (anything outside
		/// this extent will be considered to be "outside" the stencil).
		/// </summary>
		// Token: 0x06006A40 RID: 27200 RVA: 0x00099897 File Offset: 0x00097A97
		public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputWholeExtent_24(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06006A41 RID: 27201
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencilSource_SetOutputWholeExtent_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the whole extent for the stencil (anything outside
		/// this extent will be considered to be "outside" the stencil).
		/// </summary>
		// Token: 0x06006A42 RID: 27202 RVA: 0x000998AF File Offset: 0x00097AAF
		public virtual void SetOutputWholeExtent(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputWholeExtent_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095A RID: 2394
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095B RID: 2395
		public new static readonly string MRClassNameKey = "class vtkImageStencilSource";
	}
}
