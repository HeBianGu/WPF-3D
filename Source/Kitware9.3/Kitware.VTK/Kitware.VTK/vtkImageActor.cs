using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageActor
	/// </summary>
	/// <remarks>
	///    draw an image in a rendered 3D scene
	///
	/// vtkImageActor is used to render an image in a 3D scene.  The image
	/// is placed at the origin of the image, and its size is controlled by the
	/// image dimensions and image spacing. The orientation of the image is
	/// orthogonal to one of the x-y-z axes depending on which plane the
	/// image is defined in.  This class has been mostly superseded by
	/// the vtkImageSlice class, which provides more functionality than
	/// vtkImageActor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageData vtkImageSliceMapper vtkImageProperty
	/// </seealso>
	// Token: 0x020007E8 RID: 2024
	public class vtkImageActor : vtkImageSlice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014CA8 RID: 85160 RVA: 0x001D6D8F File Offset: 0x001D4F8F
		static vtkImageActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014CA9 RID: 85161 RVA: 0x001D6DB7 File Offset: 0x001D4FB7
		public vtkImageActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014CAA RID: 85162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the image actor.
		/// </summary>
		// Token: 0x06014CAB RID: 85163 RVA: 0x001D6DC8 File Offset: 0x001D4FC8
		public new static vtkImageActor New()
		{
			vtkImageActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActor.vtkImageActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the image actor.
		/// </summary>
		// Token: 0x06014CAC RID: 85164 RVA: 0x001D6E1C File Offset: 0x001D501C
		public vtkImageActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageActor.vtkImageActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014CAD RID: 85165 RVA: 0x001D6E60 File Offset: 0x001D5060
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014CAE RID: 85166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_ForceOpaqueOff_01(HandleRef pThis);

		/// <summary>
		/// Force the actor to be rendered during the opaque rendering pass.
		/// Default is false.
		/// See also: ForceTranslucentOn() to use translucent rendering pass.
		/// </summary>
		// Token: 0x06014CAF RID: 85167 RVA: 0x001D6E6B File Offset: 0x001D506B
		public virtual void ForceOpaqueOff()
		{
			vtkImageActor.vtkImageActor_ForceOpaqueOff_01(base.GetCppThis());
		}

		// Token: 0x06014CB0 RID: 85168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_ForceOpaqueOn_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to be rendered during the opaque rendering pass.
		/// Default is false.
		/// See also: ForceTranslucentOn() to use translucent rendering pass.
		/// </summary>
		// Token: 0x06014CB1 RID: 85169 RVA: 0x001D6E7A File Offset: 0x001D507A
		public virtual void ForceOpaqueOn()
		{
			vtkImageActor.vtkImageActor_ForceOpaqueOn_02(base.GetCppThis());
		}

		// Token: 0x06014CB2 RID: 85170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Get the bounds of this image actor. Either copy the bounds
		/// into a user provided array or return a pointer to an array.
		/// In either case the bounds is expressed as a 6-vector
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06014CB3 RID: 85171 RVA: 0x001D6E8C File Offset: 0x001D508C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014CB4 RID: 85172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds of this image actor. Either copy the bounds
		/// into a user provided array or return a pointer to an array.
		/// In either case the bounds is expressed as a 6-vector
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06014CB5 RID: 85173 RVA: 0x001D6ED4 File Offset: 0x001D50D4
		public new void GetBounds(IntPtr bounds)
		{
			vtkImageActor.vtkImageActor_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x06014CB6 RID: 85174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_GetDisplayBounds_05(HandleRef pThis);

		/// <summary>
		/// Get the bounds of the data that is displayed by this image
		/// actor.  If the transformation matrix for this actor is the
		/// identity matrix, this will return the same value as
		/// GetBounds.
		/// </summary>
		// Token: 0x06014CB7 RID: 85175 RVA: 0x001D6EE4 File Offset: 0x001D50E4
		public IntPtr GetDisplayBounds()
		{
			return vtkImageActor.vtkImageActor_GetDisplayBounds_05(base.GetCppThis());
		}

		// Token: 0x06014CB8 RID: 85176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_GetDisplayBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the data that is displayed by this image
		/// actor.  If the transformation matrix for this actor is the
		/// identity matrix, this will return the same value as
		/// GetBounds.
		/// </summary>
		// Token: 0x06014CB9 RID: 85177 RVA: 0x001D6F03 File Offset: 0x001D5103
		public void GetDisplayBounds(IntPtr bounds)
		{
			vtkImageActor.vtkImageActor_GetDisplayBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x06014CBA RID: 85178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_GetDisplayExtent_07(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The image extent is generally set explicitly, but if not set
		/// it will be determined from the input image data.
		/// </summary>
		// Token: 0x06014CBB RID: 85179 RVA: 0x001D6F13 File Offset: 0x001D5113
		public void GetDisplayExtent(IntPtr extent)
		{
			vtkImageActor.vtkImageActor_GetDisplayExtent_07(base.GetCppThis(), extent);
		}

		// Token: 0x06014CBC RID: 85180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_GetDisplayExtent_08(HandleRef pThis);

		/// <summary>
		/// The image extent is generally set explicitly, but if not set
		/// it will be determined from the input image data.
		/// </summary>
		// Token: 0x06014CBD RID: 85181 RVA: 0x001D6F24 File Offset: 0x001D5124
		public int[] GetDisplayExtent()
		{
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetDisplayExtent_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014CBE RID: 85182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageActor_GetForceOpaque_09(HandleRef pThis);

		/// <summary>
		/// Force the actor to be rendered during the opaque rendering pass.
		/// Default is false.
		/// See also: ForceTranslucentOn() to use translucent rendering pass.
		/// </summary>
		// Token: 0x06014CBF RID: 85183 RVA: 0x001D6F6C File Offset: 0x001D516C
		public virtual bool GetForceOpaque()
		{
			return vtkImageActor.vtkImageActor_GetForceOpaque_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06014CC0 RID: 85184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the image data input for the image actor.  This is for
		/// backwards compatibility, for a proper pipeline connection you
		/// should use GetMapper()-&gt;SetInputConnection() instead.
		/// </summary>
		// Token: 0x06014CC1 RID: 85185 RVA: 0x001D6F94 File Offset: 0x001D5194
		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActor.vtkImageActor_GetInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014CC2 RID: 85186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetInterpolate_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the image when rendering.
		/// More options are available in the Property of the image actor.
		/// </summary>
		// Token: 0x06014CC3 RID: 85187 RVA: 0x001D7004 File Offset: 0x001D5204
		public virtual int GetInterpolate()
		{
			return vtkImageActor.vtkImageActor_GetInterpolate_11(base.GetCppThis());
		}

		// Token: 0x06014CC4 RID: 85188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageActor_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CC5 RID: 85189 RVA: 0x001D7024 File Offset: 0x001D5224
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageActor.vtkImageActor_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06014CC6 RID: 85190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageActor_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CC7 RID: 85191 RVA: 0x001D7044 File Offset: 0x001D5244
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageActor.vtkImageActor_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06014CC8 RID: 85192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageActor_GetOpacity_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent. The default is 1.0.
		/// </summary>
		// Token: 0x06014CC9 RID: 85193 RVA: 0x001D7060 File Offset: 0x001D5260
		public virtual double GetOpacity()
		{
			return vtkImageActor.vtkImageActor_GetOpacity_14(base.GetCppThis());
		}

		// Token: 0x06014CCA RID: 85194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageActor_GetOpacityMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent. The default is 1.0.
		/// </summary>
		// Token: 0x06014CCB RID: 85195 RVA: 0x001D7080 File Offset: 0x001D5280
		public double GetOpacityMaxValue()
		{
			return vtkImageActor.vtkImageActor_GetOpacityMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06014CCC RID: 85196
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageActor_GetOpacityMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent. The default is 1.0.
		/// </summary>
		// Token: 0x06014CCD RID: 85197 RVA: 0x001D70A0 File Offset: 0x001D52A0
		public double GetOpacityMinValue()
		{
			return vtkImageActor.vtkImageActor_GetOpacityMinValue_16(base.GetCppThis());
		}

		// Token: 0x06014CCE RID: 85198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetSliceNumber_17(HandleRef pThis);

		/// <summary>
		/// Return the slice number (&amp; min/max slice number) computed from the display
		/// extent.
		/// </summary>
		// Token: 0x06014CCF RID: 85199 RVA: 0x001D70C0 File Offset: 0x001D52C0
		public int GetSliceNumber()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumber_17(base.GetCppThis());
		}

		// Token: 0x06014CD0 RID: 85200
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetSliceNumberMax_18(HandleRef pThis);

		/// <summary>
		/// Return the slice number (&amp; min/max slice number) computed from the display
		/// extent.
		/// </summary>
		// Token: 0x06014CD1 RID: 85201 RVA: 0x001D70E0 File Offset: 0x001D52E0
		public int GetSliceNumberMax()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumberMax_18(base.GetCppThis());
		}

		// Token: 0x06014CD2 RID: 85202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetSliceNumberMin_19(HandleRef pThis);

		/// <summary>
		/// Return the slice number (&amp; min/max slice number) computed from the display
		/// extent.
		/// </summary>
		// Token: 0x06014CD3 RID: 85203 RVA: 0x001D7100 File Offset: 0x001D5300
		public int GetSliceNumberMin()
		{
			return vtkImageActor.vtkImageActor_GetSliceNumberMin_19(base.GetCppThis());
		}

		// Token: 0x06014CD4 RID: 85204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetWholeZMax_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06014CD5 RID: 85205 RVA: 0x001D7120 File Offset: 0x001D5320
		public int GetWholeZMax()
		{
			return vtkImageActor.vtkImageActor_GetWholeZMax_20(base.GetCppThis());
		}

		// Token: 0x06014CD6 RID: 85206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetWholeZMin_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06014CD7 RID: 85207 RVA: 0x001D7140 File Offset: 0x001D5340
		public int GetWholeZMin()
		{
			return vtkImageActor.vtkImageActor_GetWholeZMin_21(base.GetCppThis());
		}

		// Token: 0x06014CD8 RID: 85208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_GetZSlice_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06014CD9 RID: 85209 RVA: 0x001D7160 File Offset: 0x001D5360
		public int GetZSlice()
		{
			return vtkImageActor.vtkImageActor_GetZSlice_22(base.GetCppThis());
		}

		// Token: 0x06014CDA RID: 85210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

		/// <summary>
		/// Internal method, should only be used by rendering.
		/// Returns true if this image actor has an alpha component or if it
		/// has an opacity that is less than 1.0.  This can be overridden by
		/// ForceOpaqueOn(), which forces this method to return false, or
		/// ForceTranslucentOn(), which forces this method to return true.
		/// </summary>
		// Token: 0x06014CDB RID: 85211 RVA: 0x001D7180 File Offset: 0x001D5380
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImageActor.vtkImageActor_HasTranslucentPolygonalGeometry_23(base.GetCppThis());
		}

		// Token: 0x06014CDC RID: 85212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_InterpolateOff_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the image when rendering.
		/// More options are available in the Property of the image actor.
		/// </summary>
		// Token: 0x06014CDD RID: 85213 RVA: 0x001D719F File Offset: 0x001D539F
		public virtual void InterpolateOff()
		{
			vtkImageActor.vtkImageActor_InterpolateOff_24(base.GetCppThis());
		}

		// Token: 0x06014CDE RID: 85214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_InterpolateOn_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off linear interpolation of the image when rendering.
		/// More options are available in the Property of the image actor.
		/// </summary>
		// Token: 0x06014CDF RID: 85215 RVA: 0x001D71AE File Offset: 0x001D53AE
		public virtual void InterpolateOn()
		{
			vtkImageActor.vtkImageActor_InterpolateOn_25(base.GetCppThis());
		}

		// Token: 0x06014CE0 RID: 85216
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CE1 RID: 85217 RVA: 0x001D71C0 File Offset: 0x001D53C0
		public override int IsA(string type)
		{
			return vtkImageActor.vtkImageActor_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06014CE2 RID: 85218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageActor_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CE3 RID: 85219 RVA: 0x001D71E0 File Offset: 0x001D53E0
		public new static int IsTypeOf(string type)
		{
			return vtkImageActor.vtkImageActor_IsTypeOf_27(type);
		}

		// Token: 0x06014CE4 RID: 85220
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CE5 RID: 85221 RVA: 0x001D71FC File Offset: 0x001D53FC
		public new vtkImageActor NewInstance()
		{
			vtkImageActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActor.vtkImageActor_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014CE6 RID: 85222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageActor_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CE7 RID: 85223 RVA: 0x001D7258 File Offset: 0x001D5458
		public new static vtkImageActor SafeDownCast(vtkObjectBase o)
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageActor.vtkImageActor_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		// Token: 0x06014CE8 RID: 85224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetDisplayExtent_31(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The image extent is generally set explicitly, but if not set
		/// it will be determined from the input image data.
		/// </summary>
		// Token: 0x06014CE9 RID: 85225 RVA: 0x001D72D7 File Offset: 0x001D54D7
		public void SetDisplayExtent(IntPtr extent)
		{
			vtkImageActor.vtkImageActor_SetDisplayExtent_31(base.GetCppThis(), extent);
		}

		// Token: 0x06014CEA RID: 85226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetDisplayExtent_32(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The image extent is generally set explicitly, but if not set
		/// it will be determined from the input image data.
		/// </summary>
		// Token: 0x06014CEB RID: 85227 RVA: 0x001D72E7 File Offset: 0x001D54E7
		public void SetDisplayExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageActor.vtkImageActor_SetDisplayExtent_32(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		// Token: 0x06014CEC RID: 85228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetForceOpaque_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force the actor to be rendered during the opaque rendering pass.
		/// Default is false.
		/// See also: ForceTranslucentOn() to use translucent rendering pass.
		/// </summary>
		// Token: 0x06014CED RID: 85229 RVA: 0x001D72FF File Offset: 0x001D54FF
		public virtual void SetForceOpaque(bool _arg)
		{
			vtkImageActor.vtkImageActor_SetForceOpaque_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014CEE RID: 85230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetInputData_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the image data input for the image actor.  This is for
		/// backwards compatibility, for a proper pipeline connection you
		/// should use GetMapper()-&gt;SetInputConnection() instead.
		/// </summary>
		// Token: 0x06014CEF RID: 85231 RVA: 0x001D7318 File Offset: 0x001D5518
		public virtual void SetInputData(vtkImageData arg0)
		{
			vtkImageActor.vtkImageActor_SetInputData_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014CF0 RID: 85232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetInterpolate_35(HandleRef pThis, int arg0);

		/// <summary>
		/// Turn on/off linear interpolation of the image when rendering.
		/// More options are available in the Property of the image actor.
		/// </summary>
		// Token: 0x06014CF1 RID: 85233 RVA: 0x001D7347 File Offset: 0x001D5547
		public virtual void SetInterpolate(int arg0)
		{
			vtkImageActor.vtkImageActor_SetInterpolate_35(base.GetCppThis(), arg0);
		}

		// Token: 0x06014CF2 RID: 85234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetOpacity_36(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent. The default is 1.0.
		/// </summary>
		// Token: 0x06014CF3 RID: 85235 RVA: 0x001D7357 File Offset: 0x001D5557
		public virtual void SetOpacity(double arg0)
		{
			vtkImageActor.vtkImageActor_SetOpacity_36(base.GetCppThis(), arg0);
		}

		// Token: 0x06014CF4 RID: 85236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageActor_SetZSlice_37(HandleRef pThis, int z);

		/// <summary>
		/// Set/Get the current slice number. The axis Z in ZSlice does not
		/// necessarily have any relation to the z axis of the data on disk.
		/// It is simply the axis orthogonal to the x,y, display plane.
		/// GetWholeZMax and Min are convenience methods for obtaining
		/// the number of slices that can be displayed. Again the number
		/// of slices is in reference to the display z axis, which is not
		/// necessarily the z axis on disk. (due to reformatting etc)
		/// </summary>
		// Token: 0x06014CF5 RID: 85237 RVA: 0x001D7367 File Offset: 0x001D5567
		public void SetZSlice(int z)
		{
			vtkImageActor.vtkImageActor_SetZSlice_37(base.GetCppThis(), z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001805 RID: 6149
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001806 RID: 6150
		public new static readonly string MRClassNameKey = "class vtkImageActor";
	}
}
