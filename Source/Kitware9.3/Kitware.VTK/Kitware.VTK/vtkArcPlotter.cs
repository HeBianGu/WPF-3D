using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArcPlotter
	/// </summary>
	/// <remarks>
	///    plot data along an arbitrary polyline
	///
	/// vtkArcPlotter performs plotting of attribute data along polylines defined
	/// with an input vtkPolyData data object. Any type of attribute data can be
	/// plotted including scalars, vectors, tensors, normals, texture coordinates,
	/// and field data. Either one or multiple data components can be plotted.
	///
	/// To use this class you must specify an input data set that contains one or
	/// more polylines, and some attribute data including which component of the
	/// attribute data. (By default, this class processes the first component of
	/// scalar data.) You will also need to set an offset radius (the distance
	/// of the polyline to the median line of the plot), a width for the plot
	/// (the distance that the minimum and maximum plot values are mapped into),
	/// an possibly an offset (used to offset attribute data with multiple
	/// components).
	///
	/// Normally the filter automatically computes normals for generating the
	/// offset arc plot. However, you can specify a default normal and use that
	/// instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXYPlotActor
	/// </seealso>
	// Token: 0x020003B1 RID: 945
	public class vtkArcPlotter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AC86 RID: 44166 RVA: 0x000F4F73 File Offset: 0x000F3173
		static vtkArcPlotter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcPlotter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcPlotter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AC87 RID: 44167 RVA: 0x000F4F9B File Offset: 0x000F319B
		public vtkArcPlotter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AC88 RID: 44168
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcPlotter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600AC89 RID: 44169 RVA: 0x000F4FAC File Offset: 0x000F31AC
		public new static vtkArcPlotter New()
		{
			vtkArcPlotter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600AC8A RID: 44170 RVA: 0x000F5000 File Offset: 0x000F3200
		public vtkArcPlotter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArcPlotter.vtkArcPlotter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AC8B RID: 44171 RVA: 0x000F5044 File Offset: 0x000F3244
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AC8C RID: 44172
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcPlotter_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a camera used to orient the plot along the arc. If no camera
		/// is specified, then the orientation of the plot is arbitrary.
		/// </summary>
		// Token: 0x0600AC8D RID: 44173 RVA: 0x000F5050 File Offset: 0x000F3250
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_GetCamera_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x0600AC8E RID: 44174
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcPlotter_GetDefaultNormal_02(HandleRef pThis);

		/// <summary>
		/// Set the default normal to use if you do not wish automatic normal
		/// calculation. The arc plot will be generated using this normal.
		/// </summary>
		// Token: 0x0600AC8F RID: 44175 RVA: 0x000F50C0 File Offset: 0x000F32C0
		public virtual float[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_GetDefaultNormal_02(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AC90 RID: 44176
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_GetDefaultNormal_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the default normal to use if you do not wish automatic normal
		/// calculation. The arc plot will be generated using this normal.
		/// </summary>
		// Token: 0x0600AC91 RID: 44177 RVA: 0x000F5108 File Offset: 0x000F3308
		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkArcPlotter.vtkArcPlotter_GetDefaultNormal_03(base.GetCppThis(), data);
		}

		// Token: 0x0600AC92 RID: 44178
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetFieldDataArray_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the field data array to plot. This instance variable is
		/// only applicable if field data is plotted.
		/// </summary>
		// Token: 0x0600AC93 RID: 44179 RVA: 0x000F5118 File Offset: 0x000F3318
		public virtual int GetFieldDataArray()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArray_04(base.GetCppThis());
		}

		// Token: 0x0600AC94 RID: 44180
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetFieldDataArrayMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the field data array to plot. This instance variable is
		/// only applicable if field data is plotted.
		/// </summary>
		// Token: 0x0600AC95 RID: 44181 RVA: 0x000F5138 File Offset: 0x000F3338
		public virtual int GetFieldDataArrayMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArrayMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600AC96 RID: 44182
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetFieldDataArrayMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the field data array to plot. This instance variable is
		/// only applicable if field data is plotted.
		/// </summary>
		// Token: 0x0600AC97 RID: 44183 RVA: 0x000F5158 File Offset: 0x000F3358
		public virtual int GetFieldDataArrayMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetFieldDataArrayMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600AC98 RID: 44184
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetHeight_07(HandleRef pThis);

		/// <summary>
		/// Set the height of the plot. (The radius combined with the height
		/// define the location of the plot relative to the generating polyline.)
		/// </summary>
		// Token: 0x0600AC99 RID: 44185 RVA: 0x000F5178 File Offset: 0x000F3378
		public virtual double GetHeight()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeight_07(base.GetCppThis());
		}

		// Token: 0x0600AC9A RID: 44186
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetHeightMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the height of the plot. (The radius combined with the height
		/// define the location of the plot relative to the generating polyline.)
		/// </summary>
		// Token: 0x0600AC9B RID: 44187 RVA: 0x000F5198 File Offset: 0x000F3398
		public virtual double GetHeightMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeightMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600AC9C RID: 44188
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetHeightMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the height of the plot. (The radius combined with the height
		/// define the location of the plot relative to the generating polyline.)
		/// </summary>
		// Token: 0x0600AC9D RID: 44189 RVA: 0x000F51B8 File Offset: 0x000F33B8
		public virtual double GetHeightMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetHeightMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600AC9E RID: 44190
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkArcPlotter_GetMTime_10(HandleRef pThis);

		/// <summary>
		/// New GetMTime because of camera dependency.
		/// </summary>
		// Token: 0x0600AC9F RID: 44191 RVA: 0x000F51D8 File Offset: 0x000F33D8
		public override ulong GetMTime()
		{
			return vtkArcPlotter.vtkArcPlotter_GetMTime_10(base.GetCppThis());
		}

		// Token: 0x0600ACA0 RID: 44192
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcPlotter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACA1 RID: 44193 RVA: 0x000F51F8 File Offset: 0x000F33F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600ACA2 RID: 44194
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcPlotter_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACA3 RID: 44195 RVA: 0x000F5218 File Offset: 0x000F3418
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600ACA4 RID: 44196
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetOffset_13(HandleRef pThis);

		/// <summary>
		/// Specify an offset that translates each subsequent plot (if there is
		/// more than one component plotted) from the defining arc (i.e., polyline).
		/// </summary>
		// Token: 0x0600ACA5 RID: 44197 RVA: 0x000F5234 File Offset: 0x000F3434
		public virtual double GetOffset()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffset_13(base.GetCppThis());
		}

		// Token: 0x0600ACA6 RID: 44198
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetOffsetMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify an offset that translates each subsequent plot (if there is
		/// more than one component plotted) from the defining arc (i.e., polyline).
		/// </summary>
		// Token: 0x0600ACA7 RID: 44199 RVA: 0x000F5254 File Offset: 0x000F3454
		public virtual double GetOffsetMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffsetMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600ACA8 RID: 44200
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetOffsetMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify an offset that translates each subsequent plot (if there is
		/// more than one component plotted) from the defining arc (i.e., polyline).
		/// </summary>
		// Token: 0x0600ACA9 RID: 44201 RVA: 0x000F5274 File Offset: 0x000F3474
		public virtual double GetOffsetMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetOffsetMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600ACAA RID: 44202
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetPlotComponent_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the component number to plot if the data has more than one
		/// component. If the value of the plot component is == (-1), then all
		/// the components will be plotted.
		/// </summary>
		// Token: 0x0600ACAB RID: 44203 RVA: 0x000F5294 File Offset: 0x000F3494
		public virtual int GetPlotComponent()
		{
			return vtkArcPlotter.vtkArcPlotter_GetPlotComponent_16(base.GetCppThis());
		}

		// Token: 0x0600ACAC RID: 44204
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetPlotMode_17(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACAD RID: 44205 RVA: 0x000F52B4 File Offset: 0x000F34B4
		public virtual int GetPlotMode()
		{
			return vtkArcPlotter.vtkArcPlotter_GetPlotMode_17(base.GetCppThis());
		}

		// Token: 0x0600ACAE RID: 44206
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetRadius_18(HandleRef pThis);

		/// <summary>
		/// Set the radius of the "median" value of the first plotted component.
		/// </summary>
		// Token: 0x0600ACAF RID: 44207 RVA: 0x000F52D4 File Offset: 0x000F34D4
		public virtual double GetRadius()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadius_18(base.GetCppThis());
		}

		// Token: 0x0600ACB0 RID: 44208
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetRadiusMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the radius of the "median" value of the first plotted component.
		/// </summary>
		// Token: 0x0600ACB1 RID: 44209 RVA: 0x000F52F4 File Offset: 0x000F34F4
		public virtual double GetRadiusMaxValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadiusMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600ACB2 RID: 44210
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkArcPlotter_GetRadiusMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the radius of the "median" value of the first plotted component.
		/// </summary>
		// Token: 0x0600ACB3 RID: 44211 RVA: 0x000F5314 File Offset: 0x000F3514
		public virtual double GetRadiusMinValue()
		{
			return vtkArcPlotter.vtkArcPlotter_GetRadiusMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600ACB4 RID: 44212
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_GetUseDefaultNormal_21(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// By default, normals are automatically computed from the generating
		/// polyline and camera.
		/// </summary>
		// Token: 0x0600ACB5 RID: 44213 RVA: 0x000F5334 File Offset: 0x000F3534
		public virtual int GetUseDefaultNormal()
		{
			return vtkArcPlotter.vtkArcPlotter_GetUseDefaultNormal_21(base.GetCppThis());
		}

		// Token: 0x0600ACB6 RID: 44214
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACB7 RID: 44215 RVA: 0x000F5354 File Offset: 0x000F3554
		public override int IsA(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600ACB8 RID: 44216
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcPlotter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACB9 RID: 44217 RVA: 0x000F5374 File Offset: 0x000F3574
		public new static int IsTypeOf(string type)
		{
			return vtkArcPlotter.vtkArcPlotter_IsTypeOf_23(type);
		}

		// Token: 0x0600ACBA RID: 44218
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcPlotter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACBB RID: 44219 RVA: 0x000F5390 File Offset: 0x000F3590
		public new vtkArcPlotter NewInstance()
		{
			vtkArcPlotter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ACBC RID: 44220
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcPlotter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate with no default camera and plot mode set to
		/// VTK_SCALARS.
		/// </summary>
		// Token: 0x0600ACBD RID: 44221 RVA: 0x000F53EC File Offset: 0x000F35EC
		public new static vtkArcPlotter SafeDownCast(vtkObjectBase o)
		{
			vtkArcPlotter vtkArcPlotter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcPlotter.vtkArcPlotter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcPlotter = (vtkArcPlotter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcPlotter.Register(null);
				}
			}
			return vtkArcPlotter;
		}

		// Token: 0x0600ACBE RID: 44222
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetCamera_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a camera used to orient the plot along the arc. If no camera
		/// is specified, then the orientation of the plot is arbitrary.
		/// </summary>
		// Token: 0x0600ACBF RID: 44223 RVA: 0x000F546C File Offset: 0x000F366C
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkArcPlotter.vtkArcPlotter_SetCamera_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600ACC0 RID: 44224
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetDefaultNormal_28(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		/// Set the default normal to use if you do not wish automatic normal
		/// calculation. The arc plot will be generated using this normal.
		/// </summary>
		// Token: 0x0600ACC1 RID: 44225 RVA: 0x000F549B File Offset: 0x000F369B
		public virtual void SetDefaultNormal(float _arg1, float _arg2, float _arg3)
		{
			vtkArcPlotter.vtkArcPlotter_SetDefaultNormal_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600ACC2 RID: 44226
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetDefaultNormal_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the default normal to use if you do not wish automatic normal
		/// calculation. The arc plot will be generated using this normal.
		/// </summary>
		// Token: 0x0600ACC3 RID: 44227 RVA: 0x000F54AD File Offset: 0x000F36AD
		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetDefaultNormal_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACC4 RID: 44228
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetFieldDataArray_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the field data array to plot. This instance variable is
		/// only applicable if field data is plotted.
		/// </summary>
		// Token: 0x0600ACC5 RID: 44229 RVA: 0x000F54BD File Offset: 0x000F36BD
		public virtual void SetFieldDataArray(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetFieldDataArray_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACC6 RID: 44230
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetHeight_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the height of the plot. (The radius combined with the height
		/// define the location of the plot relative to the generating polyline.)
		/// </summary>
		// Token: 0x0600ACC7 RID: 44231 RVA: 0x000F54CD File Offset: 0x000F36CD
		public virtual void SetHeight(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetHeight_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACC8 RID: 44232
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetOffset_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify an offset that translates each subsequent plot (if there is
		/// more than one component plotted) from the defining arc (i.e., polyline).
		/// </summary>
		// Token: 0x0600ACC9 RID: 44233 RVA: 0x000F54DD File Offset: 0x000F36DD
		public virtual void SetOffset(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetOffset_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACCA RID: 44234
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotComponent_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the component number to plot if the data has more than one
		/// component. If the value of the plot component is == (-1), then all
		/// the components will be plotted.
		/// </summary>
		// Token: 0x0600ACCB RID: 44235 RVA: 0x000F54ED File Offset: 0x000F36ED
		public virtual void SetPlotComponent(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotComponent_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACCC RID: 44236
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotMode_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACCD RID: 44237 RVA: 0x000F54FD File Offset: 0x000F36FD
		public virtual void SetPlotMode(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotMode_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACCE RID: 44238
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotFieldData_35(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACCF RID: 44239 RVA: 0x000F550D File Offset: 0x000F370D
		public void SetPlotModeToPlotFieldData()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotFieldData_35(base.GetCppThis());
		}

		// Token: 0x0600ACD0 RID: 44240
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotNormals_36(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACD1 RID: 44241 RVA: 0x000F551C File Offset: 0x000F371C
		public void SetPlotModeToPlotNormals()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotNormals_36(base.GetCppThis());
		}

		// Token: 0x0600ACD2 RID: 44242
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotScalars_37(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACD3 RID: 44243 RVA: 0x000F552B File Offset: 0x000F372B
		public void SetPlotModeToPlotScalars()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotScalars_37(base.GetCppThis());
		}

		// Token: 0x0600ACD4 RID: 44244
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotTCoords_38(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACD5 RID: 44245 RVA: 0x000F553A File Offset: 0x000F373A
		public void SetPlotModeToPlotTCoords()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotTCoords_38(base.GetCppThis());
		}

		// Token: 0x0600ACD6 RID: 44246
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotTensors_39(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACD7 RID: 44247 RVA: 0x000F5549 File Offset: 0x000F3749
		public void SetPlotModeToPlotTensors()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotTensors_39(base.GetCppThis());
		}

		// Token: 0x0600ACD8 RID: 44248
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetPlotModeToPlotVectors_40(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetPlotComponent to control which component to plot.
		/// </summary>
		// Token: 0x0600ACD9 RID: 44249 RVA: 0x000F5558 File Offset: 0x000F3758
		public void SetPlotModeToPlotVectors()
		{
			vtkArcPlotter.vtkArcPlotter_SetPlotModeToPlotVectors_40(base.GetCppThis());
		}

		// Token: 0x0600ACDA RID: 44250
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetRadius_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the radius of the "median" value of the first plotted component.
		/// </summary>
		// Token: 0x0600ACDB RID: 44251 RVA: 0x000F5567 File Offset: 0x000F3767
		public virtual void SetRadius(double _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetRadius_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACDC RID: 44252
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_SetUseDefaultNormal_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// By default, normals are automatically computed from the generating
		/// polyline and camera.
		/// </summary>
		// Token: 0x0600ACDD RID: 44253 RVA: 0x000F5577 File Offset: 0x000F3777
		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkArcPlotter.vtkArcPlotter_SetUseDefaultNormal_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ACDE RID: 44254
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_UseDefaultNormalOff_43(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// By default, normals are automatically computed from the generating
		/// polyline and camera.
		/// </summary>
		// Token: 0x0600ACDF RID: 44255 RVA: 0x000F5587 File Offset: 0x000F3787
		public virtual void UseDefaultNormalOff()
		{
			vtkArcPlotter.vtkArcPlotter_UseDefaultNormalOff_43(base.GetCppThis());
		}

		// Token: 0x0600ACE0 RID: 44256
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcPlotter_UseDefaultNormalOn_44(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// By default, normals are automatically computed from the generating
		/// polyline and camera.
		/// </summary>
		// Token: 0x0600ACE1 RID: 44257 RVA: 0x000F5596 File Offset: 0x000F3796
		public virtual void UseDefaultNormalOn()
		{
			vtkArcPlotter.vtkArcPlotter_UseDefaultNormalOn_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D97 RID: 3479
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcPlotter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D98 RID: 3480
		public new static readonly string MRClassNameKey = "class vtkArcPlotter";
	}
}
