using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxesActor
	/// </summary>
	/// <remarks>
	///    a 3D axes representation
	///
	/// vtkAxesActor is a hybrid 2D/3D actor used to represent 3D axes in a scene.
	/// The user can define the geometry to use for the shaft or the tip, and the
	/// user can set the text for the three axes. The text will appear to follow the
	/// camera since it is implemented by means of vtkCaptionActor2D.  All of the
	/// functionality of the underlying vtkCaptionActor2D objects are accessible so
	/// that, for instance, the font attributes of the axes text can be manipulated
	/// through vtkTextProperty. Since this class inherits from vtkProp3D, one can
	/// apply a user transform to the underlying geometry and the positioning of the
	/// labels. For example, a rotation transform could be used to generate a
	/// left-handed axes representation.
	///
	/// @par Thanks:
	/// Thanks to Goodwin Lawlor for posting a tcl script which featured the
	/// use of vtkCaptionActor2D to implement the text labels.  This class is
	/// based on Paraview's vtkPVAxesActor.
	///
	/// @warning
	/// vtkAxesActor is primarily intended for use with vtkOrientationMarkerWidget.
	/// The bounds of this actor are calculated as though the geometry of the axes
	/// were symmetric: that is, although only positive axes are visible, bounds
	/// are calculated as though negative axes are present too.  This is done
	/// intentionally to implement functionality of the camera update mechanism
	/// in vtkOrientationMarkerWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAnnotatedCubeActor vtkOrientationMarkerWidget vtkCaptionActor2D
	/// vtkTextProperty
	/// </seealso>
	// Token: 0x020003B2 RID: 946
	public class vtkAxesActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ACE2 RID: 44258 RVA: 0x000F55A5 File Offset: 0x000F37A5
		static vtkAxesActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ACE3 RID: 44259 RVA: 0x000F55CD File Offset: 0x000F37CD
		public vtkAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ACE4 RID: 44260
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ACE5 RID: 44261 RVA: 0x000F55DC File Offset: 0x000F37DC
		public new static vtkAxesActor New()
		{
			vtkAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ACE6 RID: 44262 RVA: 0x000F5630 File Offset: 0x000F3830
		public vtkAxesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxesActor.vtkAxesActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ACE7 RID: 44263 RVA: 0x000F5674 File Offset: 0x000F3874
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ACE8 RID: 44264
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_AxisLabelsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x0600ACE9 RID: 44265 RVA: 0x000F567F File Offset: 0x000F387F
		public virtual void AxisLabelsOff()
		{
			vtkAxesActor.vtkAxesActor_AxisLabelsOff_01(base.GetCppThis());
		}

		// Token: 0x0600ACEA RID: 44266
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_AxisLabelsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x0600ACEB RID: 44267 RVA: 0x000F568E File Offset: 0x000F388E
		public virtual void AxisLabelsOn()
		{
			vtkAxesActor.vtkAxesActor_AxisLabelsOn_02(base.GetCppThis());
		}

		// Token: 0x0600ACEC RID: 44268
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetActors_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600ACED RID: 44269 RVA: 0x000F56A0 File Offset: 0x000F38A0
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAxesActor.vtkAxesActor_GetActors_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600ACEE RID: 44270
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetAxisLabels_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x0600ACEF RID: 44271 RVA: 0x000F56D0 File Offset: 0x000F38D0
		public virtual int GetAxisLabels()
		{
			return vtkAxesActor.vtkAxesActor_GetAxisLabels_04(base.GetCppThis());
		}

		// Token: 0x0600ACF0 RID: 44272
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x0600ACF1 RID: 44273 RVA: 0x000F56EF File Offset: 0x000F38EF
		public new void GetBounds(IntPtr bounds)
		{
			vtkAxesActor.vtkAxesActor_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x0600ACF2 RID: 44274
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax). (The
		/// method GetBounds(double bounds[6]) is available from the superclass.)
		/// </summary>
		// Token: 0x0600ACF3 RID: 44275 RVA: 0x000F5700 File Offset: 0x000F3900
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ACF4 RID: 44276
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetConeRadius_07(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACF5 RID: 44277 RVA: 0x000F5748 File Offset: 0x000F3948
		public virtual double GetConeRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadius_07(base.GetCppThis());
		}

		// Token: 0x0600ACF6 RID: 44278
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetConeRadiusMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACF7 RID: 44279 RVA: 0x000F5768 File Offset: 0x000F3968
		public virtual double GetConeRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadiusMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600ACF8 RID: 44280
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetConeRadiusMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACF9 RID: 44281 RVA: 0x000F5788 File Offset: 0x000F3988
		public virtual double GetConeRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeRadiusMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600ACFA RID: 44282
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetConeResolution_10(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACFB RID: 44283 RVA: 0x000F57A8 File Offset: 0x000F39A8
		public virtual int GetConeResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolution_10(base.GetCppThis());
		}

		// Token: 0x0600ACFC RID: 44284
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetConeResolutionMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACFD RID: 44285 RVA: 0x000F57C8 File Offset: 0x000F39C8
		public virtual int GetConeResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolutionMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600ACFE RID: 44286
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetConeResolutionMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600ACFF RID: 44287 RVA: 0x000F57E8 File Offset: 0x000F39E8
		public virtual int GetConeResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetConeResolutionMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600AD00 RID: 44288
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetCylinderRadius_13(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD01 RID: 44289 RVA: 0x000F5808 File Offset: 0x000F3A08
		public virtual double GetCylinderRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadius_13(base.GetCppThis());
		}

		// Token: 0x0600AD02 RID: 44290
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetCylinderRadiusMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD03 RID: 44291 RVA: 0x000F5828 File Offset: 0x000F3A28
		public virtual double GetCylinderRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadiusMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600AD04 RID: 44292
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetCylinderRadiusMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD05 RID: 44293 RVA: 0x000F5848 File Offset: 0x000F3A48
		public virtual double GetCylinderRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderRadiusMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600AD06 RID: 44294
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetCylinderResolution_16(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD07 RID: 44295 RVA: 0x000F5868 File Offset: 0x000F3A68
		public virtual int GetCylinderResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolution_16(base.GetCppThis());
		}

		// Token: 0x0600AD08 RID: 44296
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetCylinderResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD09 RID: 44297 RVA: 0x000F5888 File Offset: 0x000F3A88
		public virtual int GetCylinderResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600AD0A RID: 44298
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetCylinderResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD0B RID: 44299 RVA: 0x000F58A8 File Offset: 0x000F3AA8
		public virtual int GetCylinderResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetCylinderResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600AD0C RID: 44300
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAxesActor_GetMTime_19(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its properties and texture if set.
		/// </summary>
		// Token: 0x0600AD0D RID: 44301 RVA: 0x000F58C8 File Offset: 0x000F3AC8
		public override ulong GetMTime()
		{
			return vtkAxesActor.vtkAxesActor_GetMTime_19(base.GetCppThis());
		}

		// Token: 0x0600AD0E RID: 44302
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetNormalizedLabelPosition_20(HandleRef pThis);

		/// <summary>
		/// Set the normalized (0-1) position of the label along the length of
		/// the shaft.  A value &gt; 1 is permissible.
		/// </summary>
		// Token: 0x0600AD0F RID: 44303 RVA: 0x000F58E8 File Offset: 0x000F3AE8
		public virtual double[] GetNormalizedLabelPosition()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedLabelPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AD10 RID: 44304
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetNormalizedLabelPosition_21(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the normalized (0-1) position of the label along the length of
		/// the shaft.  A value &gt; 1 is permissible.
		/// </summary>
		// Token: 0x0600AD11 RID: 44305 RVA: 0x000F5930 File Offset: 0x000F3B30
		public virtual void GetNormalizedLabelPosition(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedLabelPosition_21(base.GetCppThis(), data);
		}

		// Token: 0x0600AD12 RID: 44306
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetNormalizedShaftLength_22(HandleRef pThis);

		/// <summary>
		/// Set the normalized (0-1) length of the shaft.
		/// </summary>
		// Token: 0x0600AD13 RID: 44307 RVA: 0x000F5940 File Offset: 0x000F3B40
		public virtual double[] GetNormalizedShaftLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedShaftLength_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AD14 RID: 44308
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetNormalizedShaftLength_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the normalized (0-1) length of the shaft.
		/// </summary>
		// Token: 0x0600AD15 RID: 44309 RVA: 0x000F5988 File Offset: 0x000F3B88
		public virtual void GetNormalizedShaftLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedShaftLength_23(base.GetCppThis(), data);
		}

		// Token: 0x0600AD16 RID: 44310
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetNormalizedTipLength_24(HandleRef pThis);

		/// <summary>
		/// Set the normalized (0-1) length of the tip.  Normally, this would be
		/// 1 - the normalized length of the shaft.
		/// </summary>
		// Token: 0x0600AD17 RID: 44311 RVA: 0x000F5998 File Offset: 0x000F3B98
		public virtual double[] GetNormalizedTipLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetNormalizedTipLength_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AD18 RID: 44312
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetNormalizedTipLength_25(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the normalized (0-1) length of the tip.  Normally, this would be
		/// 1 - the normalized length of the shaft.
		/// </summary>
		// Token: 0x0600AD19 RID: 44313 RVA: 0x000F59E0 File Offset: 0x000F3BE0
		public virtual void GetNormalizedTipLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetNormalizedTipLength_25(base.GetCppThis(), data);
		}

		// Token: 0x0600AD1A RID: 44314
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesActor_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD1B RID: 44315 RVA: 0x000F59F0 File Offset: 0x000F3BF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxesActor.vtkAxesActor_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x0600AD1C RID: 44316
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxesActor_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD1D RID: 44317 RVA: 0x000F5A10 File Offset: 0x000F3C10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxesActor.vtkAxesActor_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x0600AD1E RID: 44318
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAxesActor_GetRedrawMTime_28(HandleRef pThis);

		/// <summary>
		/// Return the mtime of anything that would cause the rendered image to
		/// appear differently. Usually this involves checking the mtime of the
		/// prop plus anything else it depends on such as properties, textures
		/// etc.
		/// </summary>
		// Token: 0x0600AD1F RID: 44319 RVA: 0x000F5A2C File Offset: 0x000F3C2C
		public override ulong GetRedrawMTime()
		{
			return vtkAxesActor.vtkAxesActor_GetRedrawMTime_28(base.GetCppThis());
		}

		// Token: 0x0600AD20 RID: 44320
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetShaftType_29(HandleRef pThis);

		/// <summary>
		/// Set the type of the shaft to a cylinder, line, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD21 RID: 44321 RVA: 0x000F5A4C File Offset: 0x000F3C4C
		public virtual int GetShaftType()
		{
			return vtkAxesActor.vtkAxesActor_GetShaftType_29(base.GetCppThis());
		}

		// Token: 0x0600AD22 RID: 44322
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetSphereRadius_30(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD23 RID: 44323 RVA: 0x000F5A6C File Offset: 0x000F3C6C
		public virtual double GetSphereRadius()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadius_30(base.GetCppThis());
		}

		// Token: 0x0600AD24 RID: 44324
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetSphereRadiusMaxValue_31(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD25 RID: 44325 RVA: 0x000F5A8C File Offset: 0x000F3C8C
		public virtual double GetSphereRadiusMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadiusMaxValue_31(base.GetCppThis());
		}

		// Token: 0x0600AD26 RID: 44326
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxesActor_GetSphereRadiusMinValue_32(HandleRef pThis);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD27 RID: 44327 RVA: 0x000F5AAC File Offset: 0x000F3CAC
		public virtual double GetSphereRadiusMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereRadiusMinValue_32(base.GetCppThis());
		}

		// Token: 0x0600AD28 RID: 44328
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetSphereResolution_33(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD29 RID: 44329 RVA: 0x000F5ACC File Offset: 0x000F3CCC
		public virtual int GetSphereResolution()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolution_33(base.GetCppThis());
		}

		// Token: 0x0600AD2A RID: 44330
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetSphereResolutionMaxValue_34(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD2B RID: 44331 RVA: 0x000F5AEC File Offset: 0x000F3CEC
		public virtual int GetSphereResolutionMaxValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolutionMaxValue_34(base.GetCppThis());
		}

		// Token: 0x0600AD2C RID: 44332
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetSphereResolutionMinValue_35(HandleRef pThis);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD2D RID: 44333 RVA: 0x000F5B0C File Offset: 0x000F3D0C
		public virtual int GetSphereResolutionMinValue()
		{
			return vtkAxesActor.vtkAxesActor_GetSphereResolutionMinValue_35(base.GetCppThis());
		}

		// Token: 0x0600AD2E RID: 44334
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_GetTipType_36(HandleRef pThis);

		/// <summary>
		/// Set the type of the tip to a cone, sphere, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD2F RID: 44335 RVA: 0x000F5B2C File Offset: 0x000F3D2C
		public virtual int GetTipType()
		{
			return vtkAxesActor.vtkAxesActor_GetTipType_36(base.GetCppThis());
		}

		// Token: 0x0600AD30 RID: 44336
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetTotalLength_37(HandleRef pThis);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// </summary>
		// Token: 0x0600AD31 RID: 44337 RVA: 0x000F5B4C File Offset: 0x000F3D4C
		public virtual double[] GetTotalLength()
		{
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetTotalLength_37(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AD32 RID: 44338
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_GetTotalLength_38(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// </summary>
		// Token: 0x0600AD33 RID: 44339 RVA: 0x000F5B94 File Offset: 0x000F3D94
		public virtual void GetTotalLength(IntPtr data)
		{
			vtkAxesActor.vtkAxesActor_GetTotalLength_38(base.GetCppThis(), data);
		}

		// Token: 0x0600AD34 RID: 44340
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetUserDefinedShaft_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the user defined shaft polydata.
		/// </summary>
		// Token: 0x0600AD35 RID: 44341 RVA: 0x000F5BA4 File Offset: 0x000F3DA4
		public virtual vtkPolyData GetUserDefinedShaft()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetUserDefinedShaft_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600AD36 RID: 44342
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetUserDefinedTip_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the user defined tip polydata.
		/// </summary>
		// Token: 0x0600AD37 RID: 44343 RVA: 0x000F5C14 File Offset: 0x000F3E14
		public virtual vtkPolyData GetUserDefinedTip()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetUserDefinedTip_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600AD38 RID: 44344
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetXAxisCaptionActor2D_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600AD39 RID: 44345 RVA: 0x000F5C84 File Offset: 0x000F3E84
		public vtkCaptionActor2D GetXAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisCaptionActor2D_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600AD3A RID: 44346
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetXAxisLabelText_42(HandleRef pThis);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD3B RID: 44347 RVA: 0x000F5CF4 File Offset: 0x000F3EF4
		public virtual string GetXAxisLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetXAxisLabelText_42(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AD3C RID: 44348
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetXAxisShaftProperty_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the shaft properties.
		/// </summary>
		// Token: 0x0600AD3D RID: 44349 RVA: 0x000F5D30 File Offset: 0x000F3F30
		public vtkProperty GetXAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisShaftProperty_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD3E RID: 44350
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetXAxisTipProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tip properties.
		/// </summary>
		// Token: 0x0600AD3F RID: 44351 RVA: 0x000F5DA0 File Offset: 0x000F3FA0
		public vtkProperty GetXAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetXAxisTipProperty_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD40 RID: 44352
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetYAxisCaptionActor2D_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600AD41 RID: 44353 RVA: 0x000F5E10 File Offset: 0x000F4010
		public vtkCaptionActor2D GetYAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisCaptionActor2D_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600AD42 RID: 44354
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetYAxisLabelText_46(HandleRef pThis);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD43 RID: 44355 RVA: 0x000F5E80 File Offset: 0x000F4080
		public virtual string GetYAxisLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetYAxisLabelText_46(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AD44 RID: 44356
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetYAxisShaftProperty_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the shaft properties.
		/// </summary>
		// Token: 0x0600AD45 RID: 44357 RVA: 0x000F5EBC File Offset: 0x000F40BC
		public vtkProperty GetYAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisShaftProperty_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD46 RID: 44358
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetYAxisTipProperty_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tip properties.
		/// </summary>
		// Token: 0x0600AD47 RID: 44359 RVA: 0x000F5F2C File Offset: 0x000F412C
		public vtkProperty GetYAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetYAxisTipProperty_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD48 RID: 44360
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetZAxisCaptionActor2D_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600AD49 RID: 44361 RVA: 0x000F5F9C File Offset: 0x000F419C
		public vtkCaptionActor2D GetZAxisCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisCaptionActor2D_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600AD4A RID: 44362
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetZAxisLabelText_50(HandleRef pThis);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD4B RID: 44363 RVA: 0x000F600C File Offset: 0x000F420C
		public virtual string GetZAxisLabelText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxesActor.vtkAxesActor_GetZAxisLabelText_50(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AD4C RID: 44364
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetZAxisShaftProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the shaft properties.
		/// </summary>
		// Token: 0x0600AD4D RID: 44365 RVA: 0x000F6048 File Offset: 0x000F4248
		public vtkProperty GetZAxisShaftProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisShaftProperty_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD4E RID: 44366
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_GetZAxisTipProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tip properties.
		/// </summary>
		// Token: 0x0600AD4F RID: 44367 RVA: 0x000F60B8 File Offset: 0x000F42B8
		public vtkProperty GetZAxisTipProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_GetZAxisTipProperty_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600AD50 RID: 44368
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_HasTranslucentPolygonalGeometry_53(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600AD51 RID: 44369 RVA: 0x000F6128 File Offset: 0x000F4328
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAxesActor.vtkAxesActor_HasTranslucentPolygonalGeometry_53(base.GetCppThis());
		}

		// Token: 0x0600AD52 RID: 44370
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_IsA_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD53 RID: 44371 RVA: 0x000F6148 File Offset: 0x000F4348
		public override int IsA(string type)
		{
			return vtkAxesActor.vtkAxesActor_IsA_54(base.GetCppThis(), type);
		}

		// Token: 0x0600AD54 RID: 44372
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_IsTypeOf_55([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD55 RID: 44373 RVA: 0x000F6168 File Offset: 0x000F4368
		public new static int IsTypeOf(string type)
		{
			return vtkAxesActor.vtkAxesActor_IsTypeOf_55(type);
		}

		// Token: 0x0600AD56 RID: 44374
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD57 RID: 44375 RVA: 0x000F6184 File Offset: 0x000F4384
		public new vtkAxesActor NewInstance()
		{
			vtkAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_NewInstance_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AD58 RID: 44376
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_ReleaseGraphicsResources_58(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600AD59 RID: 44377 RVA: 0x000F61E0 File Offset: 0x000F43E0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxesActor.vtkAxesActor_ReleaseGraphicsResources_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AD5A RID: 44378
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_RenderOpaqueGeometry_59(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AD5B RID: 44379 RVA: 0x000F6210 File Offset: 0x000F4410
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderOpaqueGeometry_59(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AD5C RID: 44380
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_RenderOverlay_60(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AD5D RID: 44381 RVA: 0x000F6244 File Offset: 0x000F4444
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderOverlay_60(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AD5E RID: 44382
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxesActor_RenderTranslucentPolygonalGeometry_61(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x0600AD5F RID: 44383 RVA: 0x000F6278 File Offset: 0x000F4478
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAxesActor.vtkAxesActor_RenderTranslucentPolygonalGeometry_61(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600AD60 RID: 44384
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxesActor_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AD61 RID: 44385 RVA: 0x000F62AC File Offset: 0x000F44AC
		public new static vtkAxesActor SafeDownCast(vtkObjectBase o)
		{
			vtkAxesActor vtkAxesActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxesActor.vtkAxesActor_SafeDownCast_62((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesActor = (vtkAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesActor.Register(null);
				}
			}
			return vtkAxesActor;
		}

		// Token: 0x0600AD62 RID: 44386
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetAxisLabels_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x0600AD63 RID: 44387 RVA: 0x000F632B File Offset: 0x000F452B
		public virtual void SetAxisLabels(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetAxisLabels_63(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD64 RID: 44388
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetConeRadius_64(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD65 RID: 44389 RVA: 0x000F633B File Offset: 0x000F453B
		public virtual void SetConeRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetConeRadius_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD66 RID: 44390
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetConeResolution_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD67 RID: 44391 RVA: 0x000F634B File Offset: 0x000F454B
		public virtual void SetConeResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetConeResolution_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD68 RID: 44392
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetCylinderRadius_66(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD69 RID: 44393 RVA: 0x000F635B File Offset: 0x000F455B
		public virtual void SetCylinderRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetCylinderRadius_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD6A RID: 44394
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetCylinderResolution_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD6B RID: 44395 RVA: 0x000F636B File Offset: 0x000F456B
		public virtual void SetCylinderResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetCylinderResolution_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD6C RID: 44396
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedLabelPosition_68(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Set the normalized (0-1) position of the label along the length of
		/// the shaft.  A value &gt; 1 is permissible.
		/// </summary>
		// Token: 0x0600AD6D RID: 44397 RVA: 0x000F637B File Offset: 0x000F457B
		public void SetNormalizedLabelPosition(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedLabelPosition_68(base.GetCppThis(), v);
		}

		// Token: 0x0600AD6E RID: 44398
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedLabelPosition_69(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the normalized (0-1) position of the label along the length of
		/// the shaft.  A value &gt; 1 is permissible.
		/// </summary>
		// Token: 0x0600AD6F RID: 44399 RVA: 0x000F638B File Offset: 0x000F458B
		public void SetNormalizedLabelPosition(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedLabelPosition_69(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AD70 RID: 44400
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedShaftLength_70(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Set the normalized (0-1) length of the shaft.
		/// </summary>
		// Token: 0x0600AD71 RID: 44401 RVA: 0x000F639D File Offset: 0x000F459D
		public void SetNormalizedShaftLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedShaftLength_70(base.GetCppThis(), v);
		}

		// Token: 0x0600AD72 RID: 44402
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedShaftLength_71(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the normalized (0-1) length of the shaft.
		/// </summary>
		// Token: 0x0600AD73 RID: 44403 RVA: 0x000F63AD File Offset: 0x000F45AD
		public void SetNormalizedShaftLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedShaftLength_71(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AD74 RID: 44404
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedTipLength_72(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Set the normalized (0-1) length of the tip.  Normally, this would be
		/// 1 - the normalized length of the shaft.
		/// </summary>
		// Token: 0x0600AD75 RID: 44405 RVA: 0x000F63BF File Offset: 0x000F45BF
		public void SetNormalizedTipLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedTipLength_72(base.GetCppThis(), v);
		}

		// Token: 0x0600AD76 RID: 44406
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetNormalizedTipLength_73(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the normalized (0-1) length of the tip.  Normally, this would be
		/// 1 - the normalized length of the shaft.
		/// </summary>
		// Token: 0x0600AD77 RID: 44407 RVA: 0x000F63CF File Offset: 0x000F45CF
		public void SetNormalizedTipLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetNormalizedTipLength_73(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AD78 RID: 44408
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetShaftType_74(HandleRef pThis, int type);

		/// <summary>
		/// Set the type of the shaft to a cylinder, line, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD79 RID: 44409 RVA: 0x000F63E1 File Offset: 0x000F45E1
		public void SetShaftType(int type)
		{
			vtkAxesActor.vtkAxesActor_SetShaftType_74(base.GetCppThis(), type);
		}

		// Token: 0x0600AD7A RID: 44410
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetShaftTypeToCylinder_75(HandleRef pThis);

		/// <summary>
		/// Set the type of the shaft to a cylinder, line, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD7B RID: 44411 RVA: 0x000F63F1 File Offset: 0x000F45F1
		public void SetShaftTypeToCylinder()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToCylinder_75(base.GetCppThis());
		}

		// Token: 0x0600AD7C RID: 44412
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetShaftTypeToLine_76(HandleRef pThis);

		/// <summary>
		/// Set the type of the shaft to a cylinder, line, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD7D RID: 44413 RVA: 0x000F6400 File Offset: 0x000F4600
		public void SetShaftTypeToLine()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToLine_76(base.GetCppThis());
		}

		// Token: 0x0600AD7E RID: 44414
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetShaftTypeToUserDefined_77(HandleRef pThis);

		/// <summary>
		/// Set the type of the shaft to a cylinder, line, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD7F RID: 44415 RVA: 0x000F640F File Offset: 0x000F460F
		public void SetShaftTypeToUserDefined()
		{
			vtkAxesActor.vtkAxesActor_SetShaftTypeToUserDefined_77(base.GetCppThis());
		}

		// Token: 0x0600AD80 RID: 44416
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetSphereRadius_78(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the radius of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD81 RID: 44417 RVA: 0x000F641E File Offset: 0x000F461E
		public virtual void SetSphereRadius(double _arg)
		{
			vtkAxesActor.vtkAxesActor_SetSphereRadius_78(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD82 RID: 44418
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetSphereResolution_79(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the resolution of the pieces of the axes actor.
		/// </summary>
		// Token: 0x0600AD83 RID: 44419 RVA: 0x000F642E File Offset: 0x000F462E
		public virtual void SetSphereResolution(int _arg)
		{
			vtkAxesActor.vtkAxesActor_SetSphereResolution_79(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD84 RID: 44420
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTipType_80(HandleRef pThis, int type);

		/// <summary>
		/// Set the type of the tip to a cone, sphere, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD85 RID: 44421 RVA: 0x000F643E File Offset: 0x000F463E
		public void SetTipType(int type)
		{
			vtkAxesActor.vtkAxesActor_SetTipType_80(base.GetCppThis(), type);
		}

		// Token: 0x0600AD86 RID: 44422
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTipTypeToCone_81(HandleRef pThis);

		/// <summary>
		/// Set the type of the tip to a cone, sphere, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD87 RID: 44423 RVA: 0x000F644E File Offset: 0x000F464E
		public void SetTipTypeToCone()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToCone_81(base.GetCppThis());
		}

		// Token: 0x0600AD88 RID: 44424
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTipTypeToSphere_82(HandleRef pThis);

		/// <summary>
		/// Set the type of the tip to a cone, sphere, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD89 RID: 44425 RVA: 0x000F645D File Offset: 0x000F465D
		public void SetTipTypeToSphere()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToSphere_82(base.GetCppThis());
		}

		// Token: 0x0600AD8A RID: 44426
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTipTypeToUserDefined_83(HandleRef pThis);

		/// <summary>
		/// Set the type of the tip to a cone, sphere, or user defined geometry.
		/// </summary>
		// Token: 0x0600AD8B RID: 44427 RVA: 0x000F646C File Offset: 0x000F466C
		public void SetTipTypeToUserDefined()
		{
			vtkAxesActor.vtkAxesActor_SetTipTypeToUserDefined_83(base.GetCppThis());
		}

		// Token: 0x0600AD8C RID: 44428
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTotalLength_84(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// </summary>
		// Token: 0x0600AD8D RID: 44429 RVA: 0x000F647B File Offset: 0x000F467B
		public void SetTotalLength(IntPtr v)
		{
			vtkAxesActor.vtkAxesActor_SetTotalLength_84(base.GetCppThis(), v);
		}

		// Token: 0x0600AD8E RID: 44430
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetTotalLength_85(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// </summary>
		// Token: 0x0600AD8F RID: 44431 RVA: 0x000F648B File Offset: 0x000F468B
		public void SetTotalLength(double x, double y, double z)
		{
			vtkAxesActor.vtkAxesActor_SetTotalLength_85(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600AD90 RID: 44432
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetUserDefinedShaft_86(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the user defined shaft polydata.
		/// </summary>
		// Token: 0x0600AD91 RID: 44433 RVA: 0x000F64A0 File Offset: 0x000F46A0
		public void SetUserDefinedShaft(vtkPolyData arg0)
		{
			vtkAxesActor.vtkAxesActor_SetUserDefinedShaft_86(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AD92 RID: 44434
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetUserDefinedTip_87(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the user defined tip polydata.
		/// </summary>
		// Token: 0x0600AD93 RID: 44435 RVA: 0x000F64D0 File Offset: 0x000F46D0
		public void SetUserDefinedTip(vtkPolyData arg0)
		{
			vtkAxesActor.vtkAxesActor_SetUserDefinedTip_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AD94 RID: 44436
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetXAxisLabelText_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD95 RID: 44437 RVA: 0x000F64FF File Offset: 0x000F46FF
		public virtual void SetXAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetXAxisLabelText_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD96 RID: 44438
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetYAxisLabelText_89(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD97 RID: 44439 RVA: 0x000F650F File Offset: 0x000F470F
		public virtual void SetYAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetYAxisLabelText_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD98 RID: 44440
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_SetZAxisLabelText_90(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the label text.
		/// </summary>
		// Token: 0x0600AD99 RID: 44441 RVA: 0x000F651F File Offset: 0x000F471F
		public virtual void SetZAxisLabelText(string _arg)
		{
			vtkAxesActor.vtkAxesActor_SetZAxisLabelText_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AD9A RID: 44442
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxesActor_ShallowCopy_91(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an axes actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600AD9B RID: 44443 RVA: 0x000F6530 File Offset: 0x000F4730
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxesActor.vtkAxesActor_ShallowCopy_91(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D99 RID: 3481
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D9A RID: 3482
		public new static readonly string MRClassNameKey = "class vtkAxesActor";

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x020003B3 RID: 947
		public enum CYLINDER_SHAFT_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000D9C RID: 3484
			CYLINDER_SHAFT,
			/// <summary>enum member</summary>
			// Token: 0x04000D9D RID: 3485
			LINE_SHAFT,
			/// <summary>enum member</summary>
			// Token: 0x04000D9E RID: 3486
			USER_DEFINED_SHAFT
		}

		/// <summary>
		/// Enable/disable drawing the axis labels.
		/// </summary>
		// Token: 0x020003B4 RID: 948
		public enum CONE_TIP_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DA0 RID: 3488
			CONE_TIP,
			/// <summary>enum member</summary>
			// Token: 0x04000DA1 RID: 3489
			SPHERE_TIP,
			/// <summary>enum member</summary>
			// Token: 0x04000DA2 RID: 3490
			USER_DEFINED_TIP
		}
	}
}
