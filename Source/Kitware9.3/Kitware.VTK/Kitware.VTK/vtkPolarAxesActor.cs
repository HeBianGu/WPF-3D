using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolarAxesActor
	/// </summary>
	/// <remarks>
	///    create an actor of a polar axes -
	///
	///
	/// vtkPolarAxesActor is a composite actor that draws polar axes in a
	/// specified plane for a give pole.
	/// Currently the plane has to be the xy plane.
	///
	/// @par Thanks:
	/// This class was written by Philippe Pebay, Kitware SAS 2011.
	/// This work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
	/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkAxisActor vtkPolarAxesActor
	/// </seealso>
	// Token: 0x020003D3 RID: 979
	public class vtkPolarAxesActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B722 RID: 46882 RVA: 0x00101B55 File Offset: 0x000FFD55
		static vtkPolarAxesActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolarAxesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolarAxesActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B723 RID: 46883 RVA: 0x00101B7D File Offset: 0x000FFD7D
		public vtkPolarAxesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B724 RID: 46884
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with label format "6.3g" and the number of labels
		/// per axis set to 3.
		/// </summary>
		// Token: 0x0600B725 RID: 46885 RVA: 0x00101B8C File Offset: 0x000FFD8C
		public new static vtkPolarAxesActor New()
		{
			vtkPolarAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with label format "6.3g" and the number of labels
		/// per axis set to 3.
		/// </summary>
		// Token: 0x0600B726 RID: 46886 RVA: 0x00101BE0 File Offset: 0x000FFDE0
		public vtkPolarAxesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolarAxesActor.vtkPolarAxesActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B727 RID: 46887 RVA: 0x00101C24 File Offset: 0x000FFE24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B728 RID: 46888
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcMinorTickVisibilityOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on the last arc.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B729 RID: 46889 RVA: 0x00101C2F File Offset: 0x000FFE2F
		public virtual void ArcMinorTickVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcMinorTickVisibilityOff_01(base.GetCppThis());
		}

		// Token: 0x0600B72A RID: 46890
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcMinorTickVisibilityOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on the last arc.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B72B RID: 46891 RVA: 0x00101C3E File Offset: 0x000FFE3E
		public virtual void ArcMinorTickVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcMinorTickVisibilityOn_02(base.GetCppThis());
		}

		// Token: 0x0600B72C RID: 46892
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTickMatchesRadialAxesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of radial axes angle for arc major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B72D RID: 46893 RVA: 0x00101C4D File Offset: 0x000FFE4D
		public virtual void ArcTickMatchesRadialAxesOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTickMatchesRadialAxesOff_03(base.GetCppThis());
		}

		// Token: 0x0600B72E RID: 46894
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTickMatchesRadialAxesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of radial axes angle for arc major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B72F RID: 46895 RVA: 0x00101C5C File Offset: 0x000FFE5C
		public virtual void ArcTickMatchesRadialAxesOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTickMatchesRadialAxesOn_04(base.GetCppThis());
		}

		// Token: 0x0600B730 RID: 46896
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTickVisibilityOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on the last arc.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B731 RID: 46897 RVA: 0x00101C6B File Offset: 0x000FFE6B
		public virtual void ArcTickVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTickVisibilityOff_05(base.GetCppThis());
		}

		// Token: 0x0600B732 RID: 46898
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTickVisibilityOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on the last arc.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B733 RID: 46899 RVA: 0x00101C7A File Offset: 0x000FFE7A
		public virtual void ArcTickVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTickVisibilityOn_06(base.GetCppThis());
		}

		// Token: 0x0600B734 RID: 46900
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTicksOriginToPolarAxisOff_07(HandleRef pThis);

		/// <summary>
		/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B735 RID: 46901 RVA: 0x00101C89 File Offset: 0x000FFE89
		public virtual void ArcTicksOriginToPolarAxisOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTicksOriginToPolarAxisOff_07(base.GetCppThis());
		}

		// Token: 0x0600B736 RID: 46902
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ArcTicksOriginToPolarAxisOn_08(HandleRef pThis);

		/// <summary>
		/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B737 RID: 46903 RVA: 0x00101C98 File Offset: 0x000FFE98
		public virtual void ArcTicksOriginToPolarAxisOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ArcTicksOriginToPolarAxisOn_08(base.GetCppThis());
		}

		// Token: 0x0600B738 RID: 46904
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AutoSubdividePolarAxisOff_09(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B739 RID: 46905 RVA: 0x00101CA7 File Offset: 0x000FFEA7
		public void AutoSubdividePolarAxisOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AutoSubdividePolarAxisOff_09(base.GetCppThis());
		}

		// Token: 0x0600B73A RID: 46906
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AutoSubdividePolarAxisOn_10(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the number of polar axis ticks and arcs should be automatically calculated.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B73B RID: 46907 RVA: 0x00101CB6 File Offset: 0x000FFEB6
		public void AutoSubdividePolarAxisOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AutoSubdividePolarAxisOn_10(base.GetCppThis());
		}

		// Token: 0x0600B73C RID: 46908
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisMinorTickVisibilityOff_11(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B73D RID: 46909 RVA: 0x00101CC5 File Offset: 0x000FFEC5
		public virtual void AxisMinorTickVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisMinorTickVisibilityOff_11(base.GetCppThis());
		}

		// Token: 0x0600B73E RID: 46910
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisMinorTickVisibilityOn_12(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B73F RID: 46911 RVA: 0x00101CD4 File Offset: 0x000FFED4
		public virtual void AxisMinorTickVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisMinorTickVisibilityOn_12(base.GetCppThis());
		}

		// Token: 0x0600B740 RID: 46912
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisTickMatchesPolarAxesOff_13(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of polar axes range for axis major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B741 RID: 46913 RVA: 0x00101CE3 File Offset: 0x000FFEE3
		public virtual void AxisTickMatchesPolarAxesOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisTickMatchesPolarAxesOff_13(base.GetCppThis());
		}

		// Token: 0x0600B742 RID: 46914
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisTickMatchesPolarAxesOn_14(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of polar axes range for axis major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B743 RID: 46915 RVA: 0x00101CF2 File Offset: 0x000FFEF2
		public virtual void AxisTickMatchesPolarAxesOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisTickMatchesPolarAxesOn_14(base.GetCppThis());
		}

		// Token: 0x0600B744 RID: 46916
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisTickVisibilityOff_15(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B745 RID: 46917 RVA: 0x00101D01 File Offset: 0x000FFF01
		public virtual void AxisTickVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisTickVisibilityOff_15(base.GetCppThis());
		}

		// Token: 0x0600B746 RID: 46918
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_AxisTickVisibilityOn_16(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B747 RID: 46919 RVA: 0x00101D10 File Offset: 0x000FFF10
		public virtual void AxisTickVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_AxisTickVisibilityOn_16(base.GetCppThis());
		}

		// Token: 0x0600B748 RID: 46920
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_DrawPolarArcsGridlinesOff_17(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner polar arcs grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B749 RID: 46921 RVA: 0x00101D1F File Offset: 0x000FFF1F
		public virtual void DrawPolarArcsGridlinesOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_DrawPolarArcsGridlinesOff_17(base.GetCppThis());
		}

		// Token: 0x0600B74A RID: 46922
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_DrawPolarArcsGridlinesOn_18(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner polar arcs grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B74B RID: 46923 RVA: 0x00101D2E File Offset: 0x000FFF2E
		public virtual void DrawPolarArcsGridlinesOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_DrawPolarArcsGridlinesOn_18(base.GetCppThis());
		}

		// Token: 0x0600B74C RID: 46924
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_DrawRadialGridlinesOff_19(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner radial grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B74D RID: 46925 RVA: 0x00101D3D File Offset: 0x000FFF3D
		public virtual void DrawRadialGridlinesOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_DrawRadialGridlinesOff_19(base.GetCppThis());
		}

		// Token: 0x0600B74E RID: 46926
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_DrawRadialGridlinesOn_20(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner radial grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B74F RID: 46927 RVA: 0x00101D4C File Offset: 0x000FFF4C
		public virtual void DrawRadialGridlinesOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_DrawRadialGridlinesOn_20(base.GetCppThis());
		}

		// Token: 0x0600B750 RID: 46928
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetArcMajorTickSize_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the major ticks on the last arc.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B751 RID: 46929 RVA: 0x00101D5C File Offset: 0x000FFF5C
		public virtual double GetArcMajorTickSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcMajorTickSize_21(base.GetCppThis());
		}

		// Token: 0x0600B752 RID: 46930
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetArcMajorTickThickness_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the thickness of the last arc ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B753 RID: 46931 RVA: 0x00101D7C File Offset: 0x000FFF7C
		public virtual double GetArcMajorTickThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcMajorTickThickness_22(base.GetCppThis());
		}

		// Token: 0x0600B754 RID: 46932
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetArcMinorTickVisibility_23(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on the last arc.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B755 RID: 46933 RVA: 0x00101D9C File Offset: 0x000FFF9C
		public virtual bool GetArcMinorTickVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcMinorTickVisibility_23(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B756 RID: 46934
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetArcTickMatchesRadialAxes_24(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of radial axes angle for arc major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B757 RID: 46935 RVA: 0x00101DC4 File Offset: 0x000FFFC4
		public virtual bool GetArcTickMatchesRadialAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcTickMatchesRadialAxes_24(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B758 RID: 46936
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetArcTickRatioSize_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Arc ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B759 RID: 46937 RVA: 0x00101DEC File Offset: 0x000FFFEC
		public virtual double GetArcTickRatioSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcTickRatioSize_25(base.GetCppThis());
		}

		// Token: 0x0600B75A RID: 46938
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetArcTickRatioThickness_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Arc ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B75B RID: 46939 RVA: 0x00101E0C File Offset: 0x0010000C
		public virtual double GetArcTickRatioThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcTickRatioThickness_26(base.GetCppThis());
		}

		// Token: 0x0600B75C RID: 46940
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetArcTickVisibility_27(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on the last arc.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B75D RID: 46941 RVA: 0x00101E2C File Offset: 0x0010002C
		public virtual bool GetArcTickVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcTickVisibility_27(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B75E RID: 46942
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetArcTicksOriginToPolarAxis_28(HandleRef pThis);

		/// <summary>
		/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B75F RID: 46943 RVA: 0x00101E54 File Offset: 0x00100054
		public virtual bool GetArcTicksOriginToPolarAxis()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetArcTicksOriginToPolarAxis_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B760 RID: 46944
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetAxisMinorTickVisibility_29(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B761 RID: 46945 RVA: 0x00101E7C File Offset: 0x0010007C
		public virtual bool GetAxisMinorTickVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetAxisMinorTickVisibility_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B762 RID: 46946
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetAxisTickMatchesPolarAxes_30(HandleRef pThis);

		/// <summary>
		/// Turn on and off the use of polar axes range for axis major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B763 RID: 46947 RVA: 0x00101EA4 File Offset: 0x001000A4
		public virtual bool GetAxisTickMatchesPolarAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetAxisTickMatchesPolarAxes_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B764 RID: 46948
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetAxisTickVisibility_31(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B765 RID: 46949 RVA: 0x00101ECC File Offset: 0x001000CC
		public virtual bool GetAxisTickVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetAxisTickVisibility_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B766 RID: 46950
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetBounds_32(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds are used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B767 RID: 46951 RVA: 0x00101EF4 File Offset: 0x001000F4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetBounds_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B768 RID: 46952
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetBounds_33(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds are used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B769 RID: 46953 RVA: 0x00101F3C File Offset: 0x0010013C
		public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetBounds_33(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		// Token: 0x0600B76A RID: 46954
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetBounds_34(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds are used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B76B RID: 46955 RVA: 0x00101F54 File Offset: 0x00100154
		public new void GetBounds(IntPtr bounds)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetBounds_34(base.GetCppThis(), bounds);
		}

		// Token: 0x0600B76C RID: 46956
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetCamera_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkPolarAxesActor.
		/// </summary>
		// Token: 0x0600B76D RID: 46957 RVA: 0x00101F64 File Offset: 0x00100164
		public vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetCamera_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B76E RID: 46958
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDeltaAngleMajor_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the angle between 2 major ticks on the last arc.
		/// Default: 45.
		/// </summary>
		// Token: 0x0600B76F RID: 46959 RVA: 0x00101FD4 File Offset: 0x001001D4
		public virtual double GetDeltaAngleMajor()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDeltaAngleMajor_36(base.GetCppThis());
		}

		// Token: 0x0600B770 RID: 46960
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDeltaAngleMinor_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the angle between 2 minor ticks on the last arc.
		/// Default: 22.5.
		/// </summary>
		// Token: 0x0600B771 RID: 46961 RVA: 0x00101FF4 File Offset: 0x001001F4
		public virtual double GetDeltaAngleMinor()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDeltaAngleMinor_37(base.GetCppThis());
		}

		// Token: 0x0600B772 RID: 46962
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDeltaRangeMajor_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the range between 2 major ticks (values displayed on the axis).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B773 RID: 46963 RVA: 0x00102014 File Offset: 0x00100214
		public virtual double GetDeltaRangeMajor()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDeltaRangeMajor_38(base.GetCppThis());
		}

		// Token: 0x0600B774 RID: 46964
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDeltaRangeMinor_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the range between 2 minor ticks.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B775 RID: 46965 RVA: 0x00102034 File Offset: 0x00100234
		public virtual double GetDeltaRangeMinor()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDeltaRangeMinor_39(base.GetCppThis());
		}

		// Token: 0x0600B776 RID: 46966
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDistanceLODThreshold_40(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.7.
		/// </summary>
		// Token: 0x0600B777 RID: 46967 RVA: 0x00102054 File Offset: 0x00100254
		public virtual double GetDistanceLODThreshold()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDistanceLODThreshold_40(base.GetCppThis());
		}

		// Token: 0x0600B778 RID: 46968
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDistanceLODThresholdMaxValue_41(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.7.
		/// </summary>
		// Token: 0x0600B779 RID: 46969 RVA: 0x00102074 File Offset: 0x00100274
		public virtual double GetDistanceLODThresholdMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDistanceLODThresholdMaxValue_41(base.GetCppThis());
		}

		// Token: 0x0600B77A RID: 46970
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetDistanceLODThresholdMinValue_42(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.7.
		/// </summary>
		// Token: 0x0600B77B RID: 46971 RVA: 0x00102094 File Offset: 0x00100294
		public virtual double GetDistanceLODThresholdMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDistanceLODThresholdMinValue_42(base.GetCppThis());
		}

		// Token: 0x0600B77C RID: 46972
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetDrawPolarArcsGridlines_43(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner polar arcs grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B77D RID: 46973 RVA: 0x001020B4 File Offset: 0x001002B4
		public virtual bool GetDrawPolarArcsGridlines()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDrawPolarArcsGridlines_43(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B77E RID: 46974
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetDrawRadialGridlines_44(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of inner radial grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B77F RID: 46975 RVA: 0x001020DC File Offset: 0x001002DC
		public virtual bool GetDrawRadialGridlines()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetDrawRadialGridlines_44(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B780 RID: 46976
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetEnableDistanceLOD_45(HandleRef pThis);

		/// <summary>
		/// Enable and disable the use of distance based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B781 RID: 46977 RVA: 0x00102104 File Offset: 0x00100304
		public virtual bool GetEnableDistanceLOD()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetEnableDistanceLOD_45(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B782 RID: 46978
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetEnableViewAngleLOD_46(HandleRef pThis);

		/// <summary>
		/// Enable and disable the use of view angle based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B783 RID: 46979 RVA: 0x0010212C File Offset: 0x0010032C
		public virtual bool GetEnableViewAngleLOD()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetEnableViewAngleLOD_46(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B784 RID: 46980
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetExponentLocation_47(HandleRef pThis);

		/// <summary>
		/// Get/Set the location of the exponent (if any) of the polar axis values.
		/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
		/// VTK_EXPONENT_LABELS
		/// </summary>
		// Token: 0x0600B785 RID: 46981 RVA: 0x00102154 File Offset: 0x00100354
		public virtual int GetExponentLocation()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetExponentLocation_47(base.GetCppThis());
		}

		// Token: 0x0600B786 RID: 46982
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetExponentLocationMaxValue_48(HandleRef pThis);

		/// <summary>
		/// Get/Set the location of the exponent (if any) of the polar axis values.
		/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
		/// VTK_EXPONENT_LABELS
		/// </summary>
		// Token: 0x0600B787 RID: 46983 RVA: 0x00102174 File Offset: 0x00100374
		public virtual int GetExponentLocationMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetExponentLocationMaxValue_48(base.GetCppThis());
		}

		// Token: 0x0600B788 RID: 46984
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetExponentLocationMinValue_49(HandleRef pThis);

		/// <summary>
		/// Get/Set the location of the exponent (if any) of the polar axis values.
		/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
		/// VTK_EXPONENT_LABELS
		/// </summary>
		// Token: 0x0600B789 RID: 46985 RVA: 0x00102194 File Offset: 0x00100394
		public virtual int GetExponentLocationMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetExponentLocationMinValue_49(base.GetCppThis());
		}

		// Token: 0x0600B78A RID: 46986
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetLastAxisTickRatioSize_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Last Radial axis ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B78B RID: 46987 RVA: 0x001021B4 File Offset: 0x001003B4
		public virtual double GetLastAxisTickRatioSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetLastAxisTickRatioSize_50(base.GetCppThis());
		}

		// Token: 0x0600B78C RID: 46988
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetLastAxisTickRatioThickness_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Last Radial axis ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B78D RID: 46989 RVA: 0x001021D4 File Offset: 0x001003D4
		public virtual double GetLastAxisTickRatioThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetLastAxisTickRatioThickness_51(base.GetCppThis());
		}

		// Token: 0x0600B78E RID: 46990
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetLastRadialAxisMajorTickSize_52(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the major ticks on the last radial axis.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B78F RID: 46991 RVA: 0x001021F4 File Offset: 0x001003F4
		public virtual double GetLastRadialAxisMajorTickSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetLastRadialAxisMajorTickSize_52(base.GetCppThis());
		}

		// Token: 0x0600B790 RID: 46992
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetLastRadialAxisMajorTickThickness_53(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the thickness of last radial axis ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B791 RID: 46993 RVA: 0x00102214 File Offset: 0x00100414
		public virtual double GetLastRadialAxisMajorTickThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetLastRadialAxisMajorTickThickness_53(base.GetCppThis());
		}

		// Token: 0x0600B792 RID: 46994
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetLastRadialAxisProperty_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set last radial axis actor properties.
		/// </summary>
		// Token: 0x0600B793 RID: 46995 RVA: 0x00102234 File Offset: 0x00100434
		public vtkProperty GetLastRadialAxisProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetLastRadialAxisProperty_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B794 RID: 46996
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetLastRadialAxisTextProperty_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the last radial axis text property.
		/// </summary>
		// Token: 0x0600B795 RID: 46997 RVA: 0x001022A4 File Offset: 0x001004A4
		public vtkTextProperty GetLastRadialAxisTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetLastRadialAxisTextProperty_55(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B796 RID: 46998
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetLog_56(HandleRef pThis);

		/// <summary>
		/// Enable/Disable log scale.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B797 RID: 46999 RVA: 0x00102314 File Offset: 0x00100514
		public virtual bool GetLog()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetLog_56(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B798 RID: 47000
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetMaximumAngle_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum radius of the polar coordinates (in degrees).
		/// Default: 90.
		/// </summary>
		// Token: 0x0600B799 RID: 47001 RVA: 0x0010233C File Offset: 0x0010053C
		public virtual double GetMaximumAngle()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetMaximumAngle_57(base.GetCppThis());
		}

		// Token: 0x0600B79A RID: 47002
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetMaximumRadius_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum radius of the polar coordinates.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B79B RID: 47003 RVA: 0x0010235C File Offset: 0x0010055C
		public virtual double GetMaximumRadius()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetMaximumRadius_58(base.GetCppThis());
		}

		// Token: 0x0600B79C RID: 47004
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetMinimumAngle_59(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum radius of the polar coordinates (in degrees).
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B79D RID: 47005 RVA: 0x0010237C File Offset: 0x0010057C
		public virtual double GetMinimumAngle()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetMinimumAngle_59(base.GetCppThis());
		}

		// Token: 0x0600B79E RID: 47006
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetMinimumRadius_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimal radius of the polar coordinates.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B79F RID: 47007 RVA: 0x0010239C File Offset: 0x0010059C
		public virtual double GetMinimumRadius()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetMinimumRadius_60(base.GetCppThis());
		}

		// Token: 0x0600B7A0 RID: 47008
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetNumberOfGenerationsFromBase_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B7A1 RID: 47009 RVA: 0x001023BC File Offset: 0x001005BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetNumberOfGenerationsFromBase_61(base.GetCppThis(), type);
		}

		// Token: 0x0600B7A2 RID: 47010
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetNumberOfGenerationsFromBaseType_62([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B7A3 RID: 47011 RVA: 0x001023DC File Offset: 0x001005DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetNumberOfGenerationsFromBaseType_62(type);
		}

		// Token: 0x0600B7A4 RID: 47012
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetNumberOfPolarAxisTicks_63(HandleRef pThis);

		/// <summary>
		/// Set/Get a number of ticks that one would like to display along polar axis.
		/// NB: it modifies DeltaRangeMajor to correspond to this number.
		/// </summary>
		// Token: 0x0600B7A5 RID: 47013 RVA: 0x001023F8 File Offset: 0x001005F8
		public int GetNumberOfPolarAxisTicks()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetNumberOfPolarAxisTicks_63(base.GetCppThis());
		}

		// Token: 0x0600B7A6 RID: 47014
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarArcResolutionPerDegree_64(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of line per degree to draw polar arc.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B7A7 RID: 47015 RVA: 0x00102418 File Offset: 0x00100618
		public virtual double GetPolarArcResolutionPerDegree()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarArcResolutionPerDegree_64(base.GetCppThis());
		}

		// Token: 0x0600B7A8 RID: 47016
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarArcResolutionPerDegreeMaxValue_65(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of line per degree to draw polar arc.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B7A9 RID: 47017 RVA: 0x00102438 File Offset: 0x00100638
		public virtual double GetPolarArcResolutionPerDegreeMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarArcResolutionPerDegreeMaxValue_65(base.GetCppThis());
		}

		// Token: 0x0600B7AA RID: 47018
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarArcResolutionPerDegreeMinValue_66(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of line per degree to draw polar arc.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B7AB RID: 47019 RVA: 0x00102458 File Offset: 0x00100658
		public virtual double GetPolarArcResolutionPerDegreeMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarArcResolutionPerDegreeMinValue_66(base.GetCppThis());
		}

		// Token: 0x0600B7AC RID: 47020
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarArcsProperty_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set principal polar arc actor property.
		/// </summary>
		// Token: 0x0600B7AD RID: 47021 RVA: 0x00102478 File Offset: 0x00100678
		public vtkProperty GetPolarArcsProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPolarArcsProperty_67(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B7AE RID: 47022
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetPolarArcsVisibility_68(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of arcs for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7AF RID: 47023 RVA: 0x001024E8 File Offset: 0x001006E8
		public virtual bool GetPolarArcsVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarArcsVisibility_68(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7B0 RID: 47024
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisLabelTextProperty_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the polar axis labels text property.
		/// </summary>
		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00102510 File Offset: 0x00100710
		public vtkTextProperty GetPolarAxisLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisLabelTextProperty_69(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B7B2 RID: 47026
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarAxisMajorTickSize_70(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the major ticks on the polar axis.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B7B3 RID: 47027 RVA: 0x00102580 File Offset: 0x00100780
		public virtual double GetPolarAxisMajorTickSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisMajorTickSize_70(base.GetCppThis());
		}

		// Token: 0x0600B7B4 RID: 47028
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarAxisMajorTickThickness_71(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the thickness of polar axis ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B7B5 RID: 47029 RVA: 0x001025A0 File Offset: 0x001007A0
		public virtual double GetPolarAxisMajorTickThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisMajorTickThickness_71(base.GetCppThis());
		}

		// Token: 0x0600B7B6 RID: 47030
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisProperty_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set polar axis actor properties.
		/// </summary>
		// Token: 0x0600B7B7 RID: 47031 RVA: 0x001025C0 File Offset: 0x001007C0
		public vtkProperty GetPolarAxisProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisProperty_72(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B7B8 RID: 47032
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarAxisTickRatioSize_73(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Polar Axis ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B7B9 RID: 47033 RVA: 0x00102630 File Offset: 0x00100830
		public virtual double GetPolarAxisTickRatioSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTickRatioSize_73(base.GetCppThis());
		}

		// Token: 0x0600B7BA RID: 47034
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarAxisTickRatioThickness_74(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between major and minor Polar Axis ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B7BB RID: 47035 RVA: 0x00102650 File Offset: 0x00100850
		public virtual double GetPolarAxisTickRatioThickness()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTickRatioThickness_74(base.GetCppThis());
		}

		// Token: 0x0600B7BC RID: 47036
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisTitle_75(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the polar axis.
		/// Default: "Radial Distance".
		/// </summary>
		// Token: 0x0600B7BD RID: 47037 RVA: 0x00102670 File Offset: 0x00100870
		public virtual string GetPolarAxisTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTitle_75(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B7BE RID: 47038
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocation_76(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the polar axes title related to the axis.
		/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7BF RID: 47039 RVA: 0x001026AC File Offset: 0x001008AC
		public virtual int GetPolarAxisTitleLocation()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTitleLocation_76(base.GetCppThis());
		}

		// Token: 0x0600B7C0 RID: 47040
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocationMaxValue_77(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the polar axes title related to the axis.
		/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7C1 RID: 47041 RVA: 0x001026CC File Offset: 0x001008CC
		public virtual int GetPolarAxisTitleLocationMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTitleLocationMaxValue_77(base.GetCppThis());
		}

		// Token: 0x0600B7C2 RID: 47042
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetPolarAxisTitleLocationMinValue_78(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the polar axes title related to the axis.
		/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7C3 RID: 47043 RVA: 0x001026EC File Offset: 0x001008EC
		public virtual int GetPolarAxisTitleLocationMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTitleLocationMinValue_78(base.GetCppThis());
		}

		// Token: 0x0600B7C4 RID: 47044
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarAxisTitleTextProperty_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the polar axis title text property.
		/// </summary>
		// Token: 0x0600B7C5 RID: 47045 RVA: 0x0010270C File Offset: 0x0010090C
		public vtkTextProperty GetPolarAxisTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisTitleTextProperty_79(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B7C6 RID: 47046
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetPolarAxisVisibility_80(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of the polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7C7 RID: 47047 RVA: 0x0010277C File Offset: 0x0010097C
		public virtual bool GetPolarAxisVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarAxisVisibility_80(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7C8 RID: 47048
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarExponentOffset_81(HandleRef pThis);

		/// <summary>
		/// Set/Get the polar exponent Y-offset.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B7C9 RID: 47049 RVA: 0x001027A4 File Offset: 0x001009A4
		public virtual double GetPolarExponentOffset()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarExponentOffset_81(base.GetCppThis());
		}

		// Token: 0x0600B7CA RID: 47050
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarLabelFormat_82(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the polar axis labels.
		/// </summary>
		// Token: 0x0600B7CB RID: 47051 RVA: 0x001027C4 File Offset: 0x001009C4
		public virtual string GetPolarLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolarAxesActor.vtkPolarAxesActor_GetPolarLabelFormat_82(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B7CC RID: 47052
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetPolarLabelOffset_83(HandleRef pThis);

		/// <summary>
		/// Set/Get the polar label Y-offset.
		/// Default: 10.
		/// </summary>
		// Token: 0x0600B7CD RID: 47053 RVA: 0x00102800 File Offset: 0x00100A00
		public virtual double GetPolarLabelOffset()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarLabelOffset_83(base.GetCppThis());
		}

		// Token: 0x0600B7CE RID: 47054
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetPolarLabelVisibility_84(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7CF RID: 47055 RVA: 0x00102820 File Offset: 0x00100A20
		public virtual bool GetPolarLabelVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarLabelVisibility_84(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7D0 RID: 47056
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetPolarTickVisibility_85(HandleRef pThis);

		/// <summary>
		/// Turn on and off the overall visibility of ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7D1 RID: 47057 RVA: 0x00102848 File Offset: 0x00100A48
		public virtual bool GetPolarTickVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarTickVisibility_85(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7D2 RID: 47058
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPolarTitleOffset_86(HandleRef pThis);

		/// <summary>
		/// Set/Get the polar title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 10).
		/// </summary>
		// Token: 0x0600B7D3 RID: 47059 RVA: 0x00102870 File Offset: 0x00100A70
		public virtual double[] GetPolarTitleOffset()
		{
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPolarTitleOffset_86(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B7D4 RID: 47060
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetPolarTitleOffset_87(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the polar title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 10).
		/// </summary>
		// Token: 0x0600B7D5 RID: 47061 RVA: 0x001028B8 File Offset: 0x00100AB8
		public virtual void GetPolarTitleOffset(IntPtr data)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetPolarTitleOffset_87(base.GetCppThis(), data);
		}

		// Token: 0x0600B7D6 RID: 47062
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetPolarTitleVisibility_88(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7D7 RID: 47063 RVA: 0x001028C8 File Offset: 0x00100AC8
		public virtual bool GetPolarTitleVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetPolarTitleVisibility_88(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7D8 RID: 47064
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetPole_89(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the coordinate of the pole.
		/// </summary>
		// Token: 0x0600B7D9 RID: 47065 RVA: 0x001028F0 File Offset: 0x00100AF0
		public virtual double[] GetPole()
		{
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetPole_89(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B7DA RID: 47066
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetPole_90(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Explicitly specify the coordinate of the pole.
		/// </summary>
		// Token: 0x0600B7DB RID: 47067 RVA: 0x00102938 File Offset: 0x00100B38
		public virtual void GetPole(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetPole_90(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B7DC RID: 47068
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetPole_91(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the coordinate of the pole.
		/// </summary>
		// Token: 0x0600B7DD RID: 47069 RVA: 0x0010294A File Offset: 0x00100B4A
		public virtual void GetPole(IntPtr _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetPole_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B7DE RID: 47070
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetRadialAngleFormat_92(HandleRef pThis);

		/// <summary>
		/// String to format angle values displayed on the radial axes.
		/// </summary>
		// Token: 0x0600B7DF RID: 47071 RVA: 0x0010295C File Offset: 0x00100B5C
		public virtual string GetRadialAngleFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAngleFormat_92(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B7E0 RID: 47072
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetRadialAxesOriginToPolarAxis_93(HandleRef pThis);

		/// <summary>
		/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7E1 RID: 47073 RVA: 0x00102998 File Offset: 0x00100B98
		public virtual bool GetRadialAxesOriginToPolarAxis()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAxesOriginToPolarAxis_93(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7E2 RID: 47074
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetRadialAxesVisibility_94(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7E3 RID: 47075 RVA: 0x001029C0 File Offset: 0x00100BC0
		public virtual bool GetRadialAxesVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAxesVisibility_94(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7E4 RID: 47076
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocation_95(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the radial axes title related to the axis.
		/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7E5 RID: 47077 RVA: 0x001029E8 File Offset: 0x00100BE8
		public virtual int GetRadialAxisTitleLocation()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAxisTitleLocation_95(base.GetCppThis());
		}

		// Token: 0x0600B7E6 RID: 47078
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocationMaxValue_96(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the radial axes title related to the axis.
		/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7E7 RID: 47079 RVA: 0x00102A08 File Offset: 0x00100C08
		public virtual int GetRadialAxisTitleLocationMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAxisTitleLocationMaxValue_96(base.GetCppThis());
		}

		// Token: 0x0600B7E8 RID: 47080
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetRadialAxisTitleLocationMinValue_97(HandleRef pThis);

		/// <summary>
		/// Get/Set the alignment of the radial axes title related to the axis.
		/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B7E9 RID: 47081 RVA: 0x00102A28 File Offset: 0x00100C28
		public virtual int GetRadialAxisTitleLocationMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialAxisTitleLocationMinValue_97(base.GetCppThis());
		}

		// Token: 0x0600B7EA RID: 47082
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetRadialTitleOffset_98(HandleRef pThis);

		/// <summary>
		/// Set/Get the radial title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 0).
		/// </summary>
		// Token: 0x0600B7EB RID: 47083 RVA: 0x00102A48 File Offset: 0x00100C48
		public virtual double[] GetRadialTitleOffset()
		{
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetRadialTitleOffset_98(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B7EC RID: 47084
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetRadialTitleOffset_99(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the radial title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 0).
		/// </summary>
		// Token: 0x0600B7ED RID: 47085 RVA: 0x00102A90 File Offset: 0x00100C90
		public virtual void GetRadialTitleOffset(IntPtr data)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetRadialTitleOffset_99(base.GetCppThis(), data);
		}

		// Token: 0x0600B7EE RID: 47086
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetRadialTitleVisibility_100(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B7EF RID: 47087 RVA: 0x00102AA0 File Offset: 0x00100CA0
		public virtual bool GetRadialTitleVisibility()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialTitleVisibility_100(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7F0 RID: 47088
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetRadialUnits_101(HandleRef pThis);

		/// <summary>
		/// Default: true
		/// </summary>
		// Token: 0x0600B7F1 RID: 47089 RVA: 0x00102AC8 File Offset: 0x00100CC8
		public virtual bool GetRadialUnits()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRadialUnits_101(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B7F2 RID: 47090
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetRange_102(HandleRef pThis);

		/// <summary>
		/// Define the range values displayed on the polar Axis.
		/// Default: (0, 10).
		/// </summary>
		// Token: 0x0600B7F3 RID: 47091 RVA: 0x00102AF0 File Offset: 0x00100CF0
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetRange_102(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B7F4 RID: 47092
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_GetRange_103(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Define the range values displayed on the polar Axis.
		/// Default: (0, 10).
		/// </summary>
		// Token: 0x0600B7F5 RID: 47093 RVA: 0x00102B38 File Offset: 0x00100D38
		public virtual void GetRange(IntPtr data)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_GetRange_103(base.GetCppThis(), data);
		}

		// Token: 0x0600B7F6 RID: 47094
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetRatio_104(HandleRef pThis);

		/// <summary>
		/// Ratio.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B7F7 RID: 47095 RVA: 0x00102B48 File Offset: 0x00100D48
		public virtual double GetRatio()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRatio_104(base.GetCppThis());
		}

		// Token: 0x0600B7F8 RID: 47096
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetRatioMaxValue_105(HandleRef pThis);

		/// <summary>
		/// Ratio.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B7F9 RID: 47097 RVA: 0x00102B68 File Offset: 0x00100D68
		public virtual double GetRatioMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRatioMaxValue_105(base.GetCppThis());
		}

		// Token: 0x0600B7FA RID: 47098
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetRatioMinValue_106(HandleRef pThis);

		/// <summary>
		/// Ratio.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B7FB RID: 47099 RVA: 0x00102B88 File Offset: 0x00100D88
		public virtual double GetRatioMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRatioMinValue_106(base.GetCppThis());
		}

		// Token: 0x0600B7FC RID: 47100
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetRequestedDeltaAngleRadialAxes_107(HandleRef pThis);

		/// <summary>
		/// Set/Get requested delta angle for radial axes.
		/// If set to 0, compute it depending on count.
		/// Default: 45.
		/// </summary>
		// Token: 0x0600B7FD RID: 47101 RVA: 0x00102BA8 File Offset: 0x00100DA8
		public virtual double GetRequestedDeltaAngleRadialAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedDeltaAngleRadialAxes_107(base.GetCppThis());
		}

		// Token: 0x0600B7FE RID: 47102
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetRequestedDeltaRangePolarAxes_108(HandleRef pThis);

		/// <summary>
		/// Set/Get requested delta range for polar axes.
		/// If set to 0, compute it depending on count.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B7FF RID: 47103 RVA: 0x00102BC8 File Offset: 0x00100DC8
		public virtual double GetRequestedDeltaRangePolarAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedDeltaRangePolarAxes_108(base.GetCppThis());
		}

		// Token: 0x0600B800 RID: 47104
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfPolarAxes_109(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of polar axes.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B801 RID: 47105 RVA: 0x00102BE8 File Offset: 0x00100DE8
		public virtual long GetRequestedNumberOfPolarAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfPolarAxes_109(base.GetCppThis());
		}

		// Token: 0x0600B802 RID: 47106
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfPolarAxesMaxValue_110(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of polar axes.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B803 RID: 47107 RVA: 0x00102C08 File Offset: 0x00100E08
		public virtual long GetRequestedNumberOfPolarAxesMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfPolarAxesMaxValue_110(base.GetCppThis());
		}

		// Token: 0x0600B804 RID: 47108
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfPolarAxesMinValue_111(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of polar axes.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B805 RID: 47109 RVA: 0x00102C28 File Offset: 0x00100E28
		public virtual long GetRequestedNumberOfPolarAxesMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfPolarAxesMinValue_111(base.GetCppThis());
		}

		// Token: 0x0600B806 RID: 47110
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxes_112(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of radial axes.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B807 RID: 47111 RVA: 0x00102C48 File Offset: 0x00100E48
		public virtual long GetRequestedNumberOfRadialAxes()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfRadialAxes_112(base.GetCppThis());
		}

		// Token: 0x0600B808 RID: 47112
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMaxValue_113(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of radial axes.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B809 RID: 47113 RVA: 0x00102C68 File Offset: 0x00100E68
		public virtual long GetRequestedNumberOfRadialAxesMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMaxValue_113(base.GetCppThis());
		}

		// Token: 0x0600B80A RID: 47114
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMinValue_114(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the number of radial axes.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B80B RID: 47115 RVA: 0x00102C88 File Offset: 0x00100E88
		public virtual long GetRequestedNumberOfRadialAxesMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetRequestedNumberOfRadialAxesMinValue_114(base.GetCppThis());
		}

		// Token: 0x0600B80C RID: 47116
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetScreenSize_115(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the screen size of title and label text.
		/// ScreenSize determines the size of the text in terms of screen
		/// pixels.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600B80D RID: 47117 RVA: 0x00102CA8 File Offset: 0x00100EA8
		public virtual double GetScreenSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetScreenSize_115(base.GetCppThis());
		}

		// Token: 0x0600B80E RID: 47118
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetSecondaryPolarArcsProperty_116(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set secondary polar arcs actors property.
		/// </summary>
		// Token: 0x0600B80F RID: 47119 RVA: 0x00102CC8 File Offset: 0x00100EC8
		public vtkProperty GetSecondaryPolarArcsProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetSecondaryPolarArcsProperty_116(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B810 RID: 47120
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetSecondaryRadialAxesProperty_117(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set secondary radial axes actors properties.
		/// </summary>
		// Token: 0x0600B811 RID: 47121 RVA: 0x00102D38 File Offset: 0x00100F38
		public vtkProperty GetSecondaryRadialAxesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetSecondaryRadialAxesProperty_117(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B812 RID: 47122
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_GetSecondaryRadialAxesTextProperty_118(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the secondary radial axes text property.
		/// </summary>
		// Token: 0x0600B813 RID: 47123 RVA: 0x00102DA8 File Offset: 0x00100FA8
		public vtkTextProperty GetSecondaryRadialAxesTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_GetSecondaryRadialAxesTextProperty_118(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B814 RID: 47124
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngle_119(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum radial angle distinguishable from polar axis.
		/// NB: This is used only when polar axis is visible.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B815 RID: 47125 RVA: 0x00102E18 File Offset: 0x00101018
		public virtual double GetSmallestVisiblePolarAngle()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetSmallestVisiblePolarAngle_119(base.GetCppThis());
		}

		// Token: 0x0600B816 RID: 47126
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngleMaxValue_120(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum radial angle distinguishable from polar axis.
		/// NB: This is used only when polar axis is visible.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B817 RID: 47127 RVA: 0x00102E38 File Offset: 0x00101038
		public virtual double GetSmallestVisiblePolarAngleMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetSmallestVisiblePolarAngleMaxValue_120(base.GetCppThis());
		}

		// Token: 0x0600B818 RID: 47128
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetSmallestVisiblePolarAngleMinValue_121(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum radial angle distinguishable from polar axis.
		/// NB: This is used only when polar axis is visible.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B819 RID: 47129 RVA: 0x00102E58 File Offset: 0x00101058
		public virtual double GetSmallestVisiblePolarAngleMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetSmallestVisiblePolarAngleMinValue_121(base.GetCppThis());
		}

		// Token: 0x0600B81A RID: 47130
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetTickLocation_122(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_BOTH.
		/// </summary>
		// Token: 0x0600B81B RID: 47131 RVA: 0x00102E78 File Offset: 0x00101078
		public virtual int GetTickLocation()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetTickLocation_122(base.GetCppThis());
		}

		// Token: 0x0600B81C RID: 47132
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetTickLocationMaxValue_123(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_BOTH.
		/// </summary>
		// Token: 0x0600B81D RID: 47133 RVA: 0x00102E98 File Offset: 0x00101098
		public virtual int GetTickLocationMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetTickLocationMaxValue_123(base.GetCppThis());
		}

		// Token: 0x0600B81E RID: 47134
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_GetTickLocationMinValue_124(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_BOTH.
		/// </summary>
		// Token: 0x0600B81F RID: 47135 RVA: 0x00102EB8 File Offset: 0x001010B8
		public virtual int GetTickLocationMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetTickLocationMinValue_124(base.GetCppThis());
		}

		// Token: 0x0600B820 RID: 47136
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetTickRatioRadiusSize_125(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between maximum radius and major ticks size.
		/// Default: 0.02.
		/// </summary>
		// Token: 0x0600B821 RID: 47137 RVA: 0x00102ED8 File Offset: 0x001010D8
		public virtual double GetTickRatioRadiusSize()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetTickRatioRadiusSize_125(base.GetCppThis());
		}

		// Token: 0x0600B822 RID: 47138
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolarAxesActor_GetUse2DMode_126(HandleRef pThis);

		/// <summary>
		/// Enable/Disable labels 2D mode (always facing the camera).
		/// </summary>
		// Token: 0x0600B823 RID: 47139 RVA: 0x00102EF8 File Offset: 0x001010F8
		public bool GetUse2DMode()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetUse2DMode_126(base.GetCppThis()) != 0;
		}

		// Token: 0x0600B824 RID: 47140
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetViewAngleLODThreshold_127(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B825 RID: 47141 RVA: 0x00102F20 File Offset: 0x00101120
		public virtual double GetViewAngleLODThreshold()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetViewAngleLODThreshold_127(base.GetCppThis());
		}

		// Token: 0x0600B826 RID: 47142
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetViewAngleLODThresholdMaxValue_128(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B827 RID: 47143 RVA: 0x00102F40 File Offset: 0x00101140
		public virtual double GetViewAngleLODThresholdMaxValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetViewAngleLODThresholdMaxValue_128(base.GetCppThis());
		}

		// Token: 0x0600B828 RID: 47144
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolarAxesActor_GetViewAngleLODThresholdMinValue_129(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B829 RID: 47145 RVA: 0x00102F60 File Offset: 0x00101160
		public virtual double GetViewAngleLODThresholdMinValue()
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_GetViewAngleLODThresholdMinValue_129(base.GetCppThis());
		}

		// Token: 0x0600B82A RID: 47146
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_IsA_130(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B82B RID: 47147 RVA: 0x00102F80 File Offset: 0x00101180
		public override int IsA(string type)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_IsA_130(base.GetCppThis(), type);
		}

		// Token: 0x0600B82C RID: 47148
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_IsTypeOf_131([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B82D RID: 47149 RVA: 0x00102FA0 File Offset: 0x001011A0
		public new static int IsTypeOf(string type)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_IsTypeOf_131(type);
		}

		// Token: 0x0600B82E RID: 47150
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_LogOff_132(HandleRef pThis);

		/// <summary>
		/// Enable/Disable log scale.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B82F RID: 47151 RVA: 0x00102FBA File Offset: 0x001011BA
		public virtual void LogOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_LogOff_132(base.GetCppThis());
		}

		// Token: 0x0600B830 RID: 47152
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_LogOn_133(HandleRef pThis);

		/// <summary>
		/// Enable/Disable log scale.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B831 RID: 47153 RVA: 0x00102FC9 File Offset: 0x001011C9
		public virtual void LogOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_LogOn_133(base.GetCppThis());
		}

		// Token: 0x0600B832 RID: 47154
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_NewInstance_135(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B833 RID: 47155 RVA: 0x00102FD8 File Offset: 0x001011D8
		public new vtkPolarAxesActor NewInstance()
		{
			vtkPolarAxesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_NewInstance_135(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B834 RID: 47156
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarArcsVisibilityOff_136(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of arcs for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B835 RID: 47157 RVA: 0x00103032 File Offset: 0x00101232
		public virtual void PolarArcsVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarArcsVisibilityOff_136(base.GetCppThis());
		}

		// Token: 0x0600B836 RID: 47158
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarArcsVisibilityOn_137(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of arcs for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B837 RID: 47159 RVA: 0x00103041 File Offset: 0x00101241
		public virtual void PolarArcsVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarArcsVisibilityOn_137(base.GetCppThis());
		}

		// Token: 0x0600B838 RID: 47160
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarAxisVisibilityOff_138(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of the polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B839 RID: 47161 RVA: 0x00103050 File Offset: 0x00101250
		public virtual void PolarAxisVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarAxisVisibilityOff_138(base.GetCppThis());
		}

		// Token: 0x0600B83A RID: 47162
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarAxisVisibilityOn_139(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of the polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B83B RID: 47163 RVA: 0x0010305F File Offset: 0x0010125F
		public virtual void PolarAxisVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarAxisVisibilityOn_139(base.GetCppThis());
		}

		// Token: 0x0600B83C RID: 47164
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarLabelVisibilityOff_140(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B83D RID: 47165 RVA: 0x0010306E File Offset: 0x0010126E
		public virtual void PolarLabelVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarLabelVisibilityOff_140(base.GetCppThis());
		}

		// Token: 0x0600B83E RID: 47166
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarLabelVisibilityOn_141(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of labels for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B83F RID: 47167 RVA: 0x0010307D File Offset: 0x0010127D
		public virtual void PolarLabelVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarLabelVisibilityOn_141(base.GetCppThis());
		}

		// Token: 0x0600B840 RID: 47168
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarTickVisibilityOff_142(HandleRef pThis);

		/// <summary>
		/// Turn on and off the overall visibility of ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B841 RID: 47169 RVA: 0x0010308C File Offset: 0x0010128C
		public virtual void PolarTickVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarTickVisibilityOff_142(base.GetCppThis());
		}

		// Token: 0x0600B842 RID: 47170
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarTickVisibilityOn_143(HandleRef pThis);

		/// <summary>
		/// Turn on and off the overall visibility of ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B843 RID: 47171 RVA: 0x0010309B File Offset: 0x0010129B
		public virtual void PolarTickVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarTickVisibilityOn_143(base.GetCppThis());
		}

		// Token: 0x0600B844 RID: 47172
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarTitleVisibilityOff_144(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B845 RID: 47173 RVA: 0x001030AA File Offset: 0x001012AA
		public virtual void PolarTitleVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarTitleVisibilityOff_144(base.GetCppThis());
		}

		// Token: 0x0600B846 RID: 47174
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_PolarTitleVisibilityOn_145(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B847 RID: 47175 RVA: 0x001030B9 File Offset: 0x001012B9
		public virtual void PolarTitleVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_PolarTitleVisibilityOn_145(base.GetCppThis());
		}

		// Token: 0x0600B848 RID: 47176
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialAxesOriginToPolarAxisOff_146(HandleRef pThis);

		/// <summary>
		/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B849 RID: 47177 RVA: 0x001030C8 File Offset: 0x001012C8
		public virtual void RadialAxesOriginToPolarAxisOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialAxesOriginToPolarAxisOff_146(base.GetCppThis());
		}

		// Token: 0x0600B84A RID: 47178
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialAxesOriginToPolarAxisOn_147(HandleRef pThis);

		/// <summary>
		/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B84B RID: 47179 RVA: 0x001030D7 File Offset: 0x001012D7
		public virtual void RadialAxesOriginToPolarAxisOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialAxesOriginToPolarAxisOn_147(base.GetCppThis());
		}

		// Token: 0x0600B84C RID: 47180
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialAxesVisibilityOff_148(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B84D RID: 47181 RVA: 0x001030E6 File Offset: 0x001012E6
		public virtual void RadialAxesVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialAxesVisibilityOff_148(base.GetCppThis());
		}

		// Token: 0x0600B84E RID: 47182
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialAxesVisibilityOn_149(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B84F RID: 47183 RVA: 0x001030F5 File Offset: 0x001012F5
		public virtual void RadialAxesVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialAxesVisibilityOn_149(base.GetCppThis());
		}

		// Token: 0x0600B850 RID: 47184
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialTitleVisibilityOff_150(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B851 RID: 47185 RVA: 0x00103104 File Offset: 0x00101304
		public virtual void RadialTitleVisibilityOff()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialTitleVisibilityOff_150(base.GetCppThis());
		}

		// Token: 0x0600B852 RID: 47186
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_RadialTitleVisibilityOn_151(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of titles for non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B853 RID: 47187 RVA: 0x00103113 File Offset: 0x00101313
		public virtual void RadialTitleVisibilityOn()
		{
			vtkPolarAxesActor.vtkPolarAxesActor_RadialTitleVisibilityOn_151(base.GetCppThis());
		}

		// Token: 0x0600B854 RID: 47188
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_ReleaseGraphicsResources_152(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B855 RID: 47189 RVA: 0x00103124 File Offset: 0x00101324
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_ReleaseGraphicsResources_152(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B856 RID: 47190
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_RenderOpaqueGeometry_153(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the polar axes
		/// </summary>
		// Token: 0x0600B857 RID: 47191 RVA: 0x00103154 File Offset: 0x00101354
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_RenderOpaqueGeometry_153(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B858 RID: 47192
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_RenderOverlay_154(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the polar axes
		/// </summary>
		// Token: 0x0600B859 RID: 47193 RVA: 0x00103188 File Offset: 0x00101388
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_RenderOverlay_154(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B85A RID: 47194
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolarAxesActor_RenderTranslucentPolygonalGeometry_155(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the polar axes
		/// </summary>
		// Token: 0x0600B85B RID: 47195 RVA: 0x001031BC File Offset: 0x001013BC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkPolarAxesActor.vtkPolarAxesActor_RenderTranslucentPolygonalGeometry_155(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B85C RID: 47196
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolarAxesActor_SafeDownCast_156(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B85D RID: 47197 RVA: 0x001031F0 File Offset: 0x001013F0
		public new static vtkPolarAxesActor SafeDownCast(vtkObjectBase o)
		{
			vtkPolarAxesActor vtkPolarAxesActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolarAxesActor.vtkPolarAxesActor_SafeDownCast_156((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolarAxesActor = (vtkPolarAxesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolarAxesActor.Register(null);
				}
			}
			return vtkPolarAxesActor;
		}

		// Token: 0x0600B85E RID: 47198
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcMajorTickSize_157(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the major ticks on the last arc.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B85F RID: 47199 RVA: 0x0010326F File Offset: 0x0010146F
		public virtual void SetArcMajorTickSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcMajorTickSize_157(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B860 RID: 47200
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcMajorTickThickness_158(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the thickness of the last arc ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B861 RID: 47201 RVA: 0x0010327F File Offset: 0x0010147F
		public virtual void SetArcMajorTickThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcMajorTickThickness_158(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B862 RID: 47202
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcMinorTickVisibility_159(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on the last arc.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B863 RID: 47203 RVA: 0x0010328F File Offset: 0x0010148F
		public virtual void SetArcMinorTickVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcMinorTickVisibility_159(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B864 RID: 47204
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcTickMatchesRadialAxes_160(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the use of radial axes angle for arc major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B865 RID: 47205 RVA: 0x001032A7 File Offset: 0x001014A7
		public virtual void SetArcTickMatchesRadialAxes(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcTickMatchesRadialAxes_160(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B866 RID: 47206
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcTickRatioSize_161(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Arc ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B867 RID: 47207 RVA: 0x001032BF File Offset: 0x001014BF
		public virtual void SetArcTickRatioSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcTickRatioSize_161(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B868 RID: 47208
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcTickRatioThickness_162(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Arc ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B869 RID: 47209 RVA: 0x001032CF File Offset: 0x001014CF
		public virtual void SetArcTickRatioThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcTickRatioThickness_162(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B86A RID: 47210
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcTickVisibility_163(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of major ticks on the last arc.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B86B RID: 47211 RVA: 0x001032DF File Offset: 0x001014DF
		public virtual void SetArcTickVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcTickVisibility_163(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B86C RID: 47212
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetArcTicksOriginToPolarAxis_164(HandleRef pThis, byte _arg);

		/// <summary>
		/// If On, the ticks are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngle Major/Minor. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B86D RID: 47213 RVA: 0x001032F7 File Offset: 0x001014F7
		public virtual void SetArcTicksOriginToPolarAxis(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetArcTicksOriginToPolarAxis_164(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B86E RID: 47214
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetAxisMinorTickVisibility_165(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of minor ticks on polar axis and last radial axis.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B86F RID: 47215 RVA: 0x0010330F File Offset: 0x0010150F
		public virtual void SetAxisMinorTickVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetAxisMinorTickVisibility_165(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B870 RID: 47216
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetAxisTickMatchesPolarAxes_166(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the use of polar axes range for axis major ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B871 RID: 47217 RVA: 0x00103327 File Offset: 0x00101527
		public virtual void SetAxisTickMatchesPolarAxes(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetAxisTickMatchesPolarAxes_166(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B872 RID: 47218
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetAxisTickVisibility_167(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of major ticks on polar axis and last radial axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B873 RID: 47219 RVA: 0x0010333F File Offset: 0x0010153F
		public virtual void SetAxisTickVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetAxisTickVisibility_167(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B874 RID: 47220
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetBounds_168(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds are used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B875 RID: 47221 RVA: 0x00103357 File Offset: 0x00101557
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetBounds_168(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600B876 RID: 47222
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetBounds_169(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds are used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// Default: (-1, 1, -1, 1, -1, 1).
		/// </summary>
		// Token: 0x0600B877 RID: 47223 RVA: 0x0010336F File Offset: 0x0010156F
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetBounds_169(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B878 RID: 47224
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetCamera_170(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkPolarAxesActor.
		/// </summary>
		// Token: 0x0600B879 RID: 47225 RVA: 0x00103380 File Offset: 0x00101580
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetCamera_170(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B87A RID: 47226
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDeltaAngleMajor_171(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the angle between 2 major ticks on the last arc.
		/// Default: 45.
		/// </summary>
		// Token: 0x0600B87B RID: 47227 RVA: 0x001033AF File Offset: 0x001015AF
		public virtual void SetDeltaAngleMajor(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDeltaAngleMajor_171(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B87C RID: 47228
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDeltaAngleMinor_172(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the angle between 2 minor ticks on the last arc.
		/// Default: 22.5.
		/// </summary>
		// Token: 0x0600B87D RID: 47229 RVA: 0x001033BF File Offset: 0x001015BF
		public virtual void SetDeltaAngleMinor(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDeltaAngleMinor_172(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B87E RID: 47230
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDeltaRangeMajor_173(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the range between 2 major ticks (values displayed on the axis).
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B87F RID: 47231 RVA: 0x001033CF File Offset: 0x001015CF
		public virtual void SetDeltaRangeMajor(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDeltaRangeMajor_173(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B880 RID: 47232
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDeltaRangeMinor_174(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the range between 2 minor ticks.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B881 RID: 47233 RVA: 0x001033DF File Offset: 0x001015DF
		public virtual void SetDeltaRangeMinor(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDeltaRangeMinor_174(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B882 RID: 47234
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDistanceLODThreshold_175(HandleRef pThis, double _arg);

		/// <summary>
		/// Set distance LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.7.
		/// </summary>
		// Token: 0x0600B883 RID: 47235 RVA: 0x001033EF File Offset: 0x001015EF
		public virtual void SetDistanceLODThreshold(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDistanceLODThreshold_175(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B884 RID: 47236
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDrawPolarArcsGridlines_176(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of inner polar arcs grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B885 RID: 47237 RVA: 0x001033FF File Offset: 0x001015FF
		public virtual void SetDrawPolarArcsGridlines(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDrawPolarArcsGridlines_176(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B886 RID: 47238
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetDrawRadialGridlines_177(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of inner radial grid lines
		/// Default: true.
		/// </summary>
		// Token: 0x0600B887 RID: 47239 RVA: 0x00103417 File Offset: 0x00101617
		public virtual void SetDrawRadialGridlines(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetDrawRadialGridlines_177(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B888 RID: 47240
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetEnableDistanceLOD_178(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable and disable the use of distance based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B889 RID: 47241 RVA: 0x0010342F File Offset: 0x0010162F
		public virtual void SetEnableDistanceLOD(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetEnableDistanceLOD_178(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B88A RID: 47242
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetEnableViewAngleLOD_179(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable and disable the use of view angle based LOD for titles and labels.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B88B RID: 47243 RVA: 0x00103447 File Offset: 0x00101647
		public virtual void SetEnableViewAngleLOD(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetEnableViewAngleLOD_179(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B88C RID: 47244
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetExponentLocation_180(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the location of the exponent (if any) of the polar axis values.
		/// Possible location: VTK_EXPONENT_BOTTOM, VTK_EXPONENT_EXTERN,
		/// VTK_EXPONENT_LABELS
		/// </summary>
		// Token: 0x0600B88D RID: 47245 RVA: 0x0010345F File Offset: 0x0010165F
		public virtual void SetExponentLocation(int _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetExponentLocation_180(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B88E RID: 47246
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastAxisTickRatioSize_181(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Last Radial axis ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B88F RID: 47247 RVA: 0x0010346F File Offset: 0x0010166F
		public virtual void SetLastAxisTickRatioSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastAxisTickRatioSize_181(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B890 RID: 47248
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastAxisTickRatioThickness_182(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Last Radial axis ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B891 RID: 47249 RVA: 0x0010347F File Offset: 0x0010167F
		public virtual void SetLastAxisTickRatioThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastAxisTickRatioThickness_182(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B892 RID: 47250
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastRadialAxisMajorTickSize_183(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the major ticks on the last radial axis.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B893 RID: 47251 RVA: 0x0010348F File Offset: 0x0010168F
		public virtual void SetLastRadialAxisMajorTickSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastRadialAxisMajorTickSize_183(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B894 RID: 47252
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastRadialAxisMajorTickThickness_184(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the thickness of last radial axis ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B895 RID: 47253 RVA: 0x0010349F File Offset: 0x0010169F
		public virtual void SetLastRadialAxisMajorTickThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastRadialAxisMajorTickThickness_184(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B896 RID: 47254
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastRadialAxisProperty_185(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Get/Set last radial axis actor properties.
		/// </summary>
		// Token: 0x0600B897 RID: 47255 RVA: 0x001034B0 File Offset: 0x001016B0
		public virtual void SetLastRadialAxisProperty(vtkProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastRadialAxisProperty_185(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B898 RID: 47256
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLastRadialAxisTextProperty_186(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the last radial axis text property.
		/// </summary>
		// Token: 0x0600B899 RID: 47257 RVA: 0x001034E0 File Offset: 0x001016E0
		public virtual void SetLastRadialAxisTextProperty(vtkTextProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLastRadialAxisTextProperty_186(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B89A RID: 47258
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetLog_187(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable log scale.
		/// Default: false.
		/// </summary>
		// Token: 0x0600B89B RID: 47259 RVA: 0x0010350F File Offset: 0x0010170F
		public virtual void SetLog(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetLog_187(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B89C RID: 47260
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetMaximumAngle_188(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the maximum radius of the polar coordinates (in degrees).
		/// Default: 90.
		/// </summary>
		// Token: 0x0600B89D RID: 47261 RVA: 0x00103527 File Offset: 0x00101727
		public virtual void SetMaximumAngle(double arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetMaximumAngle_188(base.GetCppThis(), arg0);
		}

		// Token: 0x0600B89E RID: 47262
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetMaximumRadius_189(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the maximum radius of the polar coordinates.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B89F RID: 47263 RVA: 0x00103537 File Offset: 0x00101737
		public virtual void SetMaximumRadius(double arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetMaximumRadius_189(base.GetCppThis(), arg0);
		}

		// Token: 0x0600B8A0 RID: 47264
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetMinimumAngle_190(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the minimum radius of the polar coordinates (in degrees).
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B8A1 RID: 47265 RVA: 0x00103547 File Offset: 0x00101747
		public virtual void SetMinimumAngle(double arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetMinimumAngle_190(base.GetCppThis(), arg0);
		}

		// Token: 0x0600B8A2 RID: 47266
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetMinimumRadius_191(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/Get the minimal radius of the polar coordinates.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B8A3 RID: 47267 RVA: 0x00103557 File Offset: 0x00101757
		public virtual void SetMinimumRadius(double arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetMinimumRadius_191(base.GetCppThis(), arg0);
		}

		// Token: 0x0600B8A4 RID: 47268
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarArcResolutionPerDegree_192(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the number of line per degree to draw polar arc.
		/// Default: 0.2.
		/// </summary>
		// Token: 0x0600B8A5 RID: 47269 RVA: 0x00103567 File Offset: 0x00101767
		public virtual void SetPolarArcResolutionPerDegree(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarArcResolutionPerDegree_192(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8A6 RID: 47270
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarArcsProperty_193(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Get/Set principal polar arc actor property.
		/// </summary>
		// Token: 0x0600B8A7 RID: 47271 RVA: 0x00103578 File Offset: 0x00101778
		public virtual void SetPolarArcsProperty(vtkProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarArcsProperty_193(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8A8 RID: 47272
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarArcsVisibility_194(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of arcs for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8A9 RID: 47273 RVA: 0x001035A7 File Offset: 0x001017A7
		public virtual void SetPolarArcsVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarArcsVisibility_194(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8AA RID: 47274
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisLabelTextProperty_195(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the polar axis labels text property.
		/// </summary>
		// Token: 0x0600B8AB RID: 47275 RVA: 0x001035C0 File Offset: 0x001017C0
		public virtual void SetPolarAxisLabelTextProperty(vtkTextProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisLabelTextProperty_195(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8AC RID: 47276
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisMajorTickSize_196(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the major ticks on the polar axis.
		/// If set to 0, compute it as a ratio of maximum radius.
		/// Default 0.
		/// </summary>
		// Token: 0x0600B8AD RID: 47277 RVA: 0x001035EF File Offset: 0x001017EF
		public virtual void SetPolarAxisMajorTickSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisMajorTickSize_196(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8AE RID: 47278
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisMajorTickThickness_197(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the thickness of polar axis ticks.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B8AF RID: 47279 RVA: 0x001035FF File Offset: 0x001017FF
		public virtual void SetPolarAxisMajorTickThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisMajorTickThickness_197(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8B0 RID: 47280
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisProperty_198(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set polar axis actor properties.
		/// </summary>
		// Token: 0x0600B8B1 RID: 47281 RVA: 0x00103610 File Offset: 0x00101810
		public virtual void SetPolarAxisProperty(vtkProperty arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisProperty_198(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B8B2 RID: 47282
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisTickRatioSize_199(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Polar Axis ticks size.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B8B3 RID: 47283 RVA: 0x0010363F File Offset: 0x0010183F
		public virtual void SetPolarAxisTickRatioSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisTickRatioSize_199(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8B4 RID: 47284
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisTickRatioThickness_200(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between major and minor Polar Axis ticks thickness.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B8B5 RID: 47285 RVA: 0x0010364F File Offset: 0x0010184F
		public virtual void SetPolarAxisTickRatioThickness(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisTickRatioThickness_200(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8B6 RID: 47286
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisTitle_201(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the polar axis.
		/// Default: "Radial Distance".
		/// </summary>
		// Token: 0x0600B8B7 RID: 47287 RVA: 0x0010365F File Offset: 0x0010185F
		public virtual void SetPolarAxisTitle(string _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisTitle_201(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8B8 RID: 47288
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisTitleLocation_202(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the alignment of the polar axes title related to the axis.
		/// Possible Alignment: VTKTITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B8B9 RID: 47289 RVA: 0x0010366F File Offset: 0x0010186F
		public virtual void SetPolarAxisTitleLocation(int _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisTitleLocation_202(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8BA RID: 47290
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisTitleTextProperty_203(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the polar axis title text property.
		/// </summary>
		// Token: 0x0600B8BB RID: 47291 RVA: 0x00103680 File Offset: 0x00101880
		public virtual void SetPolarAxisTitleTextProperty(vtkTextProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisTitleTextProperty_203(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8BC RID: 47292
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarAxisVisibility_204(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of the polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8BD RID: 47293 RVA: 0x001036AF File Offset: 0x001018AF
		public virtual void SetPolarAxisVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarAxisVisibility_204(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8BE RID: 47294
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarExponentOffset_205(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the polar exponent Y-offset.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B8BF RID: 47295 RVA: 0x001036C7 File Offset: 0x001018C7
		public virtual void SetPolarExponentOffset(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarExponentOffset_205(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8C0 RID: 47296
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarLabelFormat_206(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the polar axis labels.
		/// </summary>
		// Token: 0x0600B8C1 RID: 47297 RVA: 0x001036D7 File Offset: 0x001018D7
		public virtual void SetPolarLabelFormat(string _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarLabelFormat_206(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8C2 RID: 47298
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarLabelOffset_207(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the polar label Y-offset.
		/// Default: 10.
		/// </summary>
		// Token: 0x0600B8C3 RID: 47299 RVA: 0x001036E7 File Offset: 0x001018E7
		public virtual void SetPolarLabelOffset(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarLabelOffset_207(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8C4 RID: 47300
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarLabelVisibility_208(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of labels for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8C5 RID: 47301 RVA: 0x001036F7 File Offset: 0x001018F7
		public virtual void SetPolarLabelVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarLabelVisibility_208(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8C6 RID: 47302
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarTickVisibility_209(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the overall visibility of ticks.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8C7 RID: 47303 RVA: 0x0010370F File Offset: 0x0010190F
		public virtual void SetPolarTickVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarTickVisibility_209(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8C8 RID: 47304
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarTitleOffset_210(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the polar title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 10).
		/// </summary>
		// Token: 0x0600B8C9 RID: 47305 RVA: 0x00103727 File Offset: 0x00101927
		public virtual void SetPolarTitleOffset(double _arg1, double _arg2)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarTitleOffset_210(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B8CA RID: 47306
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarTitleOffset_211(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the polar title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 10).
		/// </summary>
		// Token: 0x0600B8CB RID: 47307 RVA: 0x00103738 File Offset: 0x00101938
		public void SetPolarTitleOffset(IntPtr _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarTitleOffset_211(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8CC RID: 47308
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPolarTitleVisibility_212(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of titles for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8CD RID: 47309 RVA: 0x00103748 File Offset: 0x00101948
		public virtual void SetPolarTitleVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPolarTitleVisibility_212(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8CE RID: 47310
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPole_213(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Explicitly specify the coordinate of the pole.
		/// </summary>
		// Token: 0x0600B8CF RID: 47311 RVA: 0x00103760 File Offset: 0x00101960
		public virtual void SetPole(IntPtr arg0)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPole_213(base.GetCppThis(), arg0);
		}

		// Token: 0x0600B8D0 RID: 47312
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetPole_214(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Explicitly specify the coordinate of the pole.
		/// </summary>
		// Token: 0x0600B8D1 RID: 47313 RVA: 0x00103770 File Offset: 0x00101970
		public virtual void SetPole(double arg0, double arg1, double arg2)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetPole_214(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600B8D2 RID: 47314
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialAngleFormat_215(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// String to format angle values displayed on the radial axes.
		/// </summary>
		// Token: 0x0600B8D3 RID: 47315 RVA: 0x00103782 File Offset: 0x00101982
		public virtual void SetRadialAngleFormat(string _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialAngleFormat_215(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8D4 RID: 47316
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialAxesOriginToPolarAxis_216(HandleRef pThis, byte _arg);

		/// <summary>
		/// If On, the radial axes are drawn from the angle of the polarAxis (i.e. this-&gt;MinimalRadius)
		/// and continue counterclockwise with the step DeltaAngleRadialAxes. if Off, the start angle is
		/// 0.0, i.e. the angle on the major radius of the ellipse.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8D5 RID: 47317 RVA: 0x00103792 File Offset: 0x00101992
		public virtual void SetRadialAxesOriginToPolarAxis(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialAxesOriginToPolarAxis_216(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8D6 RID: 47318
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialAxesVisibility_217(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8D7 RID: 47319 RVA: 0x001037AA File Offset: 0x001019AA
		public virtual void SetRadialAxesVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialAxesVisibility_217(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8D8 RID: 47320
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialAxisTitleLocation_218(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the alignment of the radial axes title related to the axis.
		/// Possible Alignment: VTK_TITLE_BOTTOM, VTK_TITLE_EXTERN.
		/// Default: VTK_TITLE_BOTTOM.
		/// </summary>
		// Token: 0x0600B8D9 RID: 47321 RVA: 0x001037C2 File Offset: 0x001019C2
		public virtual void SetRadialAxisTitleLocation(int _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialAxisTitleLocation_218(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8DA RID: 47322
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialTitleOffset_219(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the radial title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 0).
		/// </summary>
		// Token: 0x0600B8DB RID: 47323 RVA: 0x001037D2 File Offset: 0x001019D2
		public virtual void SetRadialTitleOffset(double _arg1, double _arg2)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialTitleOffset_219(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B8DC RID: 47324
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialTitleOffset_220(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the radial title offset.
		/// X-component is used only if text is not aligned to center.
		/// Default: (20, 0).
		/// </summary>
		// Token: 0x0600B8DD RID: 47325 RVA: 0x001037E3 File Offset: 0x001019E3
		public void SetRadialTitleOffset(IntPtr _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialTitleOffset_220(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8DE RID: 47326
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialTitleVisibility_221(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on and off the visibility of titles for non-polar radial axes.
		/// Default: true.
		/// </summary>
		// Token: 0x0600B8DF RID: 47327 RVA: 0x001037F3 File Offset: 0x001019F3
		public virtual void SetRadialTitleVisibility(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialTitleVisibility_221(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8E0 RID: 47328
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRadialUnits_222(HandleRef pThis, byte _arg);

		/// <summary>
		/// Default: true
		/// </summary>
		// Token: 0x0600B8E1 RID: 47329 RVA: 0x0010380B File Offset: 0x00101A0B
		public virtual void SetRadialUnits(bool _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRadialUnits_222(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B8E2 RID: 47330
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRange_223(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Define the range values displayed on the polar Axis.
		/// Default: (0, 10).
		/// </summary>
		// Token: 0x0600B8E3 RID: 47331 RVA: 0x00103823 File Offset: 0x00101A23
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRange_223(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B8E4 RID: 47332
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRange_224(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Define the range values displayed on the polar Axis.
		/// Default: (0, 10).
		/// </summary>
		// Token: 0x0600B8E5 RID: 47333 RVA: 0x00103834 File Offset: 0x00101A34
		public void SetRange(IntPtr _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRange_224(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8E6 RID: 47334
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRatio_225(HandleRef pThis, double _arg);

		/// <summary>
		/// Ratio.
		/// Default: 1.
		/// </summary>
		// Token: 0x0600B8E7 RID: 47335 RVA: 0x00103844 File Offset: 0x00101A44
		public virtual void SetRatio(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRatio_225(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8E8 RID: 47336
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRequestedDeltaAngleRadialAxes_226(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get requested delta angle for radial axes.
		/// If set to 0, compute it depending on count.
		/// Default: 45.
		/// </summary>
		// Token: 0x0600B8E9 RID: 47337 RVA: 0x00103854 File Offset: 0x00101A54
		public virtual void SetRequestedDeltaAngleRadialAxes(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRequestedDeltaAngleRadialAxes_226(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8EA RID: 47338
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRequestedDeltaRangePolarAxes_227(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get requested delta range for polar axes.
		/// If set to 0, compute it depending on count.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B8EB RID: 47339 RVA: 0x00103864 File Offset: 0x00101A64
		public virtual void SetRequestedDeltaRangePolarAxes(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRequestedDeltaRangePolarAxes_227(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8EC RID: 47340
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRequestedNumberOfPolarAxes_228(HandleRef pThis, long _arg);

		/// <summary>
		/// Gets/Sets the number of polar axes.
		/// Default: 5.
		/// </summary>
		// Token: 0x0600B8ED RID: 47341 RVA: 0x00103874 File Offset: 0x00101A74
		public virtual void SetRequestedNumberOfPolarAxes(long _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRequestedNumberOfPolarAxes_228(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8EE RID: 47342
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetRequestedNumberOfRadialAxes_229(HandleRef pThis, long _arg);

		/// <summary>
		/// Gets/Sets the number of radial axes.
		/// Default: 0.
		/// </summary>
		// Token: 0x0600B8EF RID: 47343 RVA: 0x00103884 File Offset: 0x00101A84
		public virtual void SetRequestedNumberOfRadialAxes(long _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetRequestedNumberOfRadialAxes_229(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8F0 RID: 47344
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetScreenSize_230(HandleRef pThis, double _arg);

		/// <summary>
		/// Explicitly specify the screen size of title and label text.
		/// ScreenSize determines the size of the text in terms of screen
		/// pixels.
		/// Default: 10.0.
		/// </summary>
		// Token: 0x0600B8F1 RID: 47345 RVA: 0x00103894 File Offset: 0x00101A94
		public virtual void SetScreenSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetScreenSize_230(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8F2 RID: 47346
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetSecondaryPolarArcsProperty_231(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Get/Set secondary polar arcs actors property.
		/// </summary>
		// Token: 0x0600B8F3 RID: 47347 RVA: 0x001038A4 File Offset: 0x00101AA4
		public virtual void SetSecondaryPolarArcsProperty(vtkProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetSecondaryPolarArcsProperty_231(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8F4 RID: 47348
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetSecondaryRadialAxesProperty_232(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Get/Set secondary radial axes actors properties.
		/// </summary>
		// Token: 0x0600B8F5 RID: 47349 RVA: 0x001038D4 File Offset: 0x00101AD4
		public virtual void SetSecondaryRadialAxesProperty(vtkProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetSecondaryRadialAxesProperty_232(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8F6 RID: 47350
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetSecondaryRadialAxesTextProperty_233(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the secondary radial axes text property.
		/// </summary>
		// Token: 0x0600B8F7 RID: 47351 RVA: 0x00103904 File Offset: 0x00101B04
		public virtual void SetSecondaryRadialAxesTextProperty(vtkTextProperty p)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetSecondaryRadialAxesTextProperty_233(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B8F8 RID: 47352
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetSmallestVisiblePolarAngle_234(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum radial angle distinguishable from polar axis.
		/// NB: This is used only when polar axis is visible.
		/// Default: 0.5.
		/// </summary>
		// Token: 0x0600B8F9 RID: 47353 RVA: 0x00103933 File Offset: 0x00101B33
		public virtual void SetSmallestVisiblePolarAngle(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetSmallestVisiblePolarAngle_234(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8FA RID: 47354
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetTickLocation_235(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the location of the ticks.
		/// Inside: tick end toward positive direction of perpendicular axes.
		/// Outside: tick end toward negative direction of perpendicular axes.
		/// Default: VTK_TICKS_BOTH.
		/// </summary>
		// Token: 0x0600B8FB RID: 47355 RVA: 0x00103943 File Offset: 0x00101B43
		public virtual void SetTickLocation(int _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetTickLocation_235(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8FC RID: 47356
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetTickRatioRadiusSize_236(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between maximum radius and major ticks size.
		/// Default: 0.02.
		/// </summary>
		// Token: 0x0600B8FD RID: 47357 RVA: 0x00103953 File Offset: 0x00101B53
		public virtual void SetTickRatioRadiusSize(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetTickRatioRadiusSize_236(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B8FE RID: 47358
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetUse2DMode_237(HandleRef pThis, byte enable);

		/// <summary>
		/// Enable/Disable labels 2D mode (always facing the camera).
		/// </summary>
		// Token: 0x0600B8FF RID: 47359 RVA: 0x00103963 File Offset: 0x00101B63
		public void SetUse2DMode(bool enable)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetUse2DMode_237(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x0600B900 RID: 47360
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolarAxesActor_SetViewAngleLODThreshold_238(HandleRef pThis, double _arg);

		/// <summary>
		/// Set view angle LOD threshold [0.0 - 1.0] for titles and labels.
		/// Default: 0.3.
		/// </summary>
		// Token: 0x0600B901 RID: 47361 RVA: 0x0010397B File Offset: 0x00101B7B
		public virtual void SetViewAngleLODThreshold(double _arg)
		{
			vtkPolarAxesActor.vtkPolarAxesActor_SetViewAngleLODThreshold_238(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E01 RID: 3585
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolarAxesActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E02 RID: 3586
		public new static readonly string MRClassNameKey = "class vtkPolarAxesActor";

		/// <summary>
		/// Set/Get the format with which to print the polar axis labels.
		/// </summary>
		// Token: 0x020003D4 RID: 980
		public enum ExponentLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E04 RID: 3588
			VTK_EXPONENT_BOTTOM,
			/// <summary>enum member</summary>
			// Token: 0x04000E05 RID: 3589
			VTK_EXPONENT_EXTERN,
			/// <summary>enum member</summary>
			// Token: 0x04000E06 RID: 3590
			VTK_EXPONENT_LABELS
		}

		/// <summary>
		/// Turn on and off the visibility of titles for polar axis.
		/// Default: true.
		/// </summary>
		// Token: 0x020003D5 RID: 981
		public enum TitleLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E08 RID: 3592
			VTK_TITLE_BOTTOM,
			/// <summary>enum member</summary>
			// Token: 0x04000E09 RID: 3593
			VTK_TITLE_EXTERN
		}
	}
}
