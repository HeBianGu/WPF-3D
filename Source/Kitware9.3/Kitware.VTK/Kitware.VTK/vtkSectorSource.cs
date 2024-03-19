using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSectorSource
	/// </summary>
	/// <remarks>
	///    create a sector of a disk
	///
	/// vtkSectorSource creates a sector of a polygonal disk. The
	/// disk has zero height. The user can specify the inner and outer radius
	/// of the disk, the z-coordinate, and the radial and
	/// circumferential resolution of the polygonal representation.
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearExtrusionFilter
	/// </seealso>
	// Token: 0x0200056D RID: 1389
	public class vtkSectorSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F612 RID: 62994 RVA: 0x0015620E File Offset: 0x0015440E
		static vtkSectorSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSectorSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSectorSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F613 RID: 62995 RVA: 0x00156236 File Offset: 0x00154436
		public vtkSectorSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F614 RID: 62996
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSectorSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F615 RID: 62997 RVA: 0x00156244 File Offset: 0x00154444
		public new static vtkSectorSource New()
		{
			vtkSectorSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F616 RID: 62998 RVA: 0x00156298 File Offset: 0x00154498
		public vtkSectorSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSectorSource.vtkSectorSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F617 RID: 62999 RVA: 0x001562DC File Offset: 0x001544DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F618 RID: 63000
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetCircumferentialResolution_01(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x0600F619 RID: 63001 RVA: 0x001562E8 File Offset: 0x001544E8
		public virtual int GetCircumferentialResolution()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolution_01(base.GetCppThis());
		}

		// Token: 0x0600F61A RID: 63002
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x0600F61B RID: 63003 RVA: 0x00156308 File Offset: 0x00154508
		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolutionMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600F61C RID: 63004
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x0600F61D RID: 63005 RVA: 0x00156328 File Offset: 0x00154528
		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetCircumferentialResolutionMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600F61E RID: 63006
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetEndAngle_04(HandleRef pThis);

		/// <summary>
		/// Set the end angle of the sector.
		/// </summary>
		// Token: 0x0600F61F RID: 63007 RVA: 0x00156348 File Offset: 0x00154548
		public virtual double GetEndAngle()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngle_04(base.GetCppThis());
		}

		// Token: 0x0600F620 RID: 63008
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetEndAngleMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set the end angle of the sector.
		/// </summary>
		// Token: 0x0600F621 RID: 63009 RVA: 0x00156368 File Offset: 0x00154568
		public virtual double GetEndAngleMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngleMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600F622 RID: 63010
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetEndAngleMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set the end angle of the sector.
		/// </summary>
		// Token: 0x0600F623 RID: 63011 RVA: 0x00156388 File Offset: 0x00154588
		public virtual double GetEndAngleMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetEndAngleMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600F624 RID: 63012
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetInnerRadius_07(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of the sector.
		/// </summary>
		// Token: 0x0600F625 RID: 63013 RVA: 0x001563A8 File Offset: 0x001545A8
		public virtual double GetInnerRadius()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadius_07(base.GetCppThis());
		}

		// Token: 0x0600F626 RID: 63014
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetInnerRadiusMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of the sector.
		/// </summary>
		// Token: 0x0600F627 RID: 63015 RVA: 0x001563C8 File Offset: 0x001545C8
		public virtual double GetInnerRadiusMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadiusMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600F628 RID: 63016
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetInnerRadiusMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify inner radius of the sector.
		/// </summary>
		// Token: 0x0600F629 RID: 63017 RVA: 0x001563E8 File Offset: 0x001545E8
		public virtual double GetInnerRadiusMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetInnerRadiusMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600F62A RID: 63018
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSectorSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F62B RID: 63019 RVA: 0x00156408 File Offset: 0x00154608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSectorSource.vtkSectorSource_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600F62C RID: 63020
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSectorSource_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F62D RID: 63021 RVA: 0x00156428 File Offset: 0x00154628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSectorSource.vtkSectorSource_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600F62E RID: 63022
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetOuterRadius_12(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of the sector.
		/// </summary>
		// Token: 0x0600F62F RID: 63023 RVA: 0x00156444 File Offset: 0x00154644
		public virtual double GetOuterRadius()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadius_12(base.GetCppThis());
		}

		// Token: 0x0600F630 RID: 63024
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetOuterRadiusMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of the sector.
		/// </summary>
		// Token: 0x0600F631 RID: 63025 RVA: 0x00156464 File Offset: 0x00154664
		public virtual double GetOuterRadiusMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadiusMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600F632 RID: 63026
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetOuterRadiusMinValue_14(HandleRef pThis);

		/// <summary>
		/// Specify outer radius of the sector.
		/// </summary>
		// Token: 0x0600F633 RID: 63027 RVA: 0x00156484 File Offset: 0x00154684
		public virtual double GetOuterRadiusMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetOuterRadiusMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600F634 RID: 63028
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetRadialResolution_15(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x0600F635 RID: 63029 RVA: 0x001564A4 File Offset: 0x001546A4
		public virtual int GetRadialResolution()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolution_15(base.GetCppThis());
		}

		// Token: 0x0600F636 RID: 63030
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetRadialResolutionMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x0600F637 RID: 63031 RVA: 0x001564C4 File Offset: 0x001546C4
		public virtual int GetRadialResolutionMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolutionMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600F638 RID: 63032
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_GetRadialResolutionMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x0600F639 RID: 63033 RVA: 0x001564E4 File Offset: 0x001546E4
		public virtual int GetRadialResolutionMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetRadialResolutionMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600F63A RID: 63034
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetStartAngle_18(HandleRef pThis);

		/// <summary>
		/// Set the start angle of the sector.
		/// </summary>
		// Token: 0x0600F63B RID: 63035 RVA: 0x00156504 File Offset: 0x00154704
		public virtual double GetStartAngle()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngle_18(base.GetCppThis());
		}

		// Token: 0x0600F63C RID: 63036
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetStartAngleMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the start angle of the sector.
		/// </summary>
		// Token: 0x0600F63D RID: 63037 RVA: 0x00156524 File Offset: 0x00154724
		public virtual double GetStartAngleMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngleMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600F63E RID: 63038
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetStartAngleMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the start angle of the sector.
		/// </summary>
		// Token: 0x0600F63F RID: 63039 RVA: 0x00156544 File Offset: 0x00154744
		public virtual double GetStartAngleMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetStartAngleMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600F640 RID: 63040
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetZCoord_21(HandleRef pThis);

		/// <summary>
		/// Specify the z coordinate of the sector.
		/// </summary>
		// Token: 0x0600F641 RID: 63041 RVA: 0x00156564 File Offset: 0x00154764
		public virtual double GetZCoord()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoord_21(base.GetCppThis());
		}

		// Token: 0x0600F642 RID: 63042
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetZCoordMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the z coordinate of the sector.
		/// </summary>
		// Token: 0x0600F643 RID: 63043 RVA: 0x00156584 File Offset: 0x00154784
		public virtual double GetZCoordMaxValue()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoordMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600F644 RID: 63044
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSectorSource_GetZCoordMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the z coordinate of the sector.
		/// </summary>
		// Token: 0x0600F645 RID: 63045 RVA: 0x001565A4 File Offset: 0x001547A4
		public virtual double GetZCoordMinValue()
		{
			return vtkSectorSource.vtkSectorSource_GetZCoordMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600F646 RID: 63046
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F647 RID: 63047 RVA: 0x001565C4 File Offset: 0x001547C4
		public override int IsA(string type)
		{
			return vtkSectorSource.vtkSectorSource_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600F648 RID: 63048
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSectorSource_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F649 RID: 63049 RVA: 0x001565E4 File Offset: 0x001547E4
		public new static int IsTypeOf(string type)
		{
			return vtkSectorSource.vtkSectorSource_IsTypeOf_25(type);
		}

		// Token: 0x0600F64A RID: 63050
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSectorSource_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F64B RID: 63051 RVA: 0x00156600 File Offset: 0x00154800
		public new vtkSectorSource NewInstance()
		{
			vtkSectorSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F64C RID: 63052
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSectorSource_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F64D RID: 63053 RVA: 0x0015665C File Offset: 0x0015485C
		public new static vtkSectorSource SafeDownCast(vtkObjectBase o)
		{
			vtkSectorSource vtkSectorSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSectorSource.vtkSectorSource_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSectorSource = (vtkSectorSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSectorSource.Register(null);
				}
			}
			return vtkSectorSource;
		}

		// Token: 0x0600F64E RID: 63054
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetCircumferentialResolution_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in circumferential direction.
		/// </summary>
		// Token: 0x0600F64F RID: 63055 RVA: 0x001566DB File Offset: 0x001548DB
		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkSectorSource.vtkSectorSource_SetCircumferentialResolution_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F650 RID: 63056
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetEndAngle_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the end angle of the sector.
		/// </summary>
		// Token: 0x0600F651 RID: 63057 RVA: 0x001566EB File Offset: 0x001548EB
		public virtual void SetEndAngle(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetEndAngle_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F652 RID: 63058
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetInnerRadius_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify inner radius of the sector.
		/// </summary>
		// Token: 0x0600F653 RID: 63059 RVA: 0x001566FB File Offset: 0x001548FB
		public virtual void SetInnerRadius(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetInnerRadius_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F654 RID: 63060
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetOuterRadius_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify outer radius of the sector.
		/// </summary>
		// Token: 0x0600F655 RID: 63061 RVA: 0x0015670B File Offset: 0x0015490B
		public virtual void SetOuterRadius(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetOuterRadius_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F656 RID: 63062
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetRadialResolution_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of points in radius direction.
		/// </summary>
		// Token: 0x0600F657 RID: 63063 RVA: 0x0015671B File Offset: 0x0015491B
		public virtual void SetRadialResolution(int _arg)
		{
			vtkSectorSource.vtkSectorSource_SetRadialResolution_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F658 RID: 63064
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetStartAngle_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the start angle of the sector.
		/// </summary>
		// Token: 0x0600F659 RID: 63065 RVA: 0x0015672B File Offset: 0x0015492B
		public virtual void SetStartAngle(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetStartAngle_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F65A RID: 63066
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSectorSource_SetZCoord_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the z coordinate of the sector.
		/// </summary>
		// Token: 0x0600F65B RID: 63067 RVA: 0x0015673B File Offset: 0x0015493B
		public virtual void SetZCoord(double _arg)
		{
			vtkSectorSource.vtkSectorSource_SetZCoord_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011EB RID: 4587
		public new const string MRFullTypeName = "Kitware.VTK.vtkSectorSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011EC RID: 4588
		public new static readonly string MRClassNameKey = "class vtkSectorSource";
	}
}
