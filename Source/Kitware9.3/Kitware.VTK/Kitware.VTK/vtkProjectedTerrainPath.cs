using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProjectedTerrainPath
	/// </summary>
	/// <remarks>
	///    project a polyline onto a terrain
	///
	/// vtkProjectedTerrainPath projects an input polyline onto a terrain. (The
	/// terrain is defined by a 2D height image and is the second input to the
	/// filter.) The polyline projection is controlled via several modes as
	/// follows. 1) Simple mode projects the polyline points onto the terrain,
	/// taking into account the height offset instance variable. 2) Non-occluded
	/// mode insures that no parts of the polyline are occluded by the terrain
	/// (e.g. a line passes through a mountain). This may require recursive
	/// subdivision of the polyline. 3) Hug mode insures that the polyine points
	/// remain within a constant distance from the surface. This may also require
	/// recursive subdivision of the polyline. Note that both non-occluded mode
	/// and hug mode also take into account the height offset, so it is possible
	/// to create paths that hug terrain a certain distance above it. To use this
	/// filter, define two inputs: 1) a polyline, and 2) an image whose scalar
	/// values represent a height field. Then specify the mode, and the height
	/// offset to use.
	///
	/// An description of the algorithm is as follows. The filter begins by
	/// projecting the polyline points to the image (offset by the specified
	/// height offset).  If the mode is non-occluded or hug, then the maximum
	/// error along each line segment is computed and placed into a priority
	/// queue. Each line segment is then split at the point of maximum error, and
	/// the two new line segments are evaluated for maximum error. This process
	/// continues until the line is not occluded by the terrain (non-occluded
	/// mode) or satisfies the error on variation from the surface (hug
	/// mode). (Note this process is repeated for each polyline in the
	/// input. Also, the maximum error is computed in two parts: a maximum
	/// positive error and maximum negative error. If the polyline is above the
	/// terrain--i.e., the height offset is positive--in non-occluded or hug mode
	/// all negative errors are eliminated. If the polyline is below the
	/// terrain--i.e., the height offset is negative--in non-occluded or hug mode
	/// all positive errors are eliminated.)
	///
	/// @warning
	/// This algorithm requires the entire input image to be in memory, hence it
	/// may not work for extremely large images.
	///
	/// @warning
	/// The input height image is assumed to be positioned in the x-y plane so the
	/// scalar value is the z-coordinate, height value.
	///
	/// @warning
	/// A priority queue is used so that the 1) the total number of line segments
	/// can be controlled, and 2) the algorithm can terminate when the errors in
	/// the queue are less than the specified error tolerance.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGreedyTerrainDecimation
	/// </seealso>
	// Token: 0x02000614 RID: 1556
	public class vtkProjectedTerrainPath : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010E9E RID: 69278 RVA: 0x0017912D File Offset: 0x0017732D
		static vtkProjectedTerrainPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTerrainPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTerrainPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010E9F RID: 69279 RVA: 0x00179155 File Offset: 0x00177355
		public vtkProjectedTerrainPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010EA0 RID: 69280
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTerrainPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06010EA1 RID: 69281 RVA: 0x00179164 File Offset: 0x00177364
		public new static vtkProjectedTerrainPath New()
		{
			vtkProjectedTerrainPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06010EA2 RID: 69282 RVA: 0x001791B8 File Offset: 0x001773B8
		public vtkProjectedTerrainPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProjectedTerrainPath.vtkProjectedTerrainPath_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010EA3 RID: 69283 RVA: 0x001791FC File Offset: 0x001773FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010EA4 RID: 69284
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProjectedTerrainPath_GetHeightOffset_01(HandleRef pThis);

		/// <summary>
		/// This is the height above (or below) the terrain that the projected
		/// path should be. Positive values indicate distances above the terrain;
		/// negative values indicate distances below the terrain.
		/// </summary>
		// Token: 0x06010EA5 RID: 69285 RVA: 0x00179208 File Offset: 0x00177408
		public virtual double GetHeightOffset()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightOffset_01(base.GetCppThis());
		}

		// Token: 0x06010EA6 RID: 69286
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProjectedTerrainPath_GetHeightTolerance_02(HandleRef pThis);

		/// <summary>
		/// This is the allowable variation in the altitude of the path
		/// with respect to the variation in the terrain. It only comes
		/// into play if the hug projection mode is enabled.
		/// </summary>
		// Token: 0x06010EA7 RID: 69287 RVA: 0x00179228 File Offset: 0x00177428
		public virtual double GetHeightTolerance()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightTolerance_02(base.GetCppThis());
		}

		// Token: 0x06010EA8 RID: 69288
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(HandleRef pThis);

		/// <summary>
		/// This is the allowable variation in the altitude of the path
		/// with respect to the variation in the terrain. It only comes
		/// into play if the hug projection mode is enabled.
		/// </summary>
		// Token: 0x06010EA9 RID: 69289 RVA: 0x00179248 File Offset: 0x00177448
		public virtual double GetHeightToleranceMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06010EAA RID: 69290
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(HandleRef pThis);

		/// <summary>
		/// This is the allowable variation in the altitude of the path
		/// with respect to the variation in the terrain. It only comes
		/// into play if the hug projection mode is enabled.
		/// </summary>
		// Token: 0x06010EAB RID: 69291 RVA: 0x00179268 File Offset: 0x00177468
		public virtual double GetHeightToleranceMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(base.GetCppThis());
		}

		// Token: 0x06010EAC RID: 69292
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(HandleRef pThis);

		/// <summary>
		/// This instance variable can be used to limit the total number of line
		/// segments created during subdivision. Note that the number of input line
		/// segments will be the minimum number that cab be output.
		/// </summary>
		// Token: 0x06010EAD RID: 69293 RVA: 0x00179288 File Offset: 0x00177488
		public virtual long GetMaximumNumberOfLines()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(base.GetCppThis());
		}

		// Token: 0x06010EAE RID: 69294
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(HandleRef pThis);

		/// <summary>
		/// This instance variable can be used to limit the total number of line
		/// segments created during subdivision. Note that the number of input line
		/// segments will be the minimum number that cab be output.
		/// </summary>
		// Token: 0x06010EAF RID: 69295 RVA: 0x001792A8 File Offset: 0x001774A8
		public virtual long GetMaximumNumberOfLinesMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06010EB0 RID: 69296
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(HandleRef pThis);

		/// <summary>
		/// This instance variable can be used to limit the total number of line
		/// segments created during subdivision. Note that the number of input line
		/// segments will be the minimum number that cab be output.
		/// </summary>
		// Token: 0x06010EB1 RID: 69297 RVA: 0x001792C8 File Offset: 0x001774C8
		public virtual long GetMaximumNumberOfLinesMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(base.GetCppThis());
		}

		// Token: 0x06010EB2 RID: 69298
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTerrainPath_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EB3 RID: 69299 RVA: 0x001792E8 File Offset: 0x001774E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06010EB4 RID: 69300
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProjectedTerrainPath_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EB5 RID: 69301 RVA: 0x00179308 File Offset: 0x00177508
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06010EB6 RID: 69302
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTerrainPath_GetProjectionMode_10(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010EB7 RID: 69303 RVA: 0x00179324 File Offset: 0x00177524
		public virtual int GetProjectionMode()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionMode_10(base.GetCppThis());
		}

		// Token: 0x06010EB8 RID: 69304
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTerrainPath_GetProjectionModeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010EB9 RID: 69305 RVA: 0x00179344 File Offset: 0x00177544
		public virtual int GetProjectionModeMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionModeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06010EBA RID: 69306
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTerrainPath_GetProjectionModeMinValue_12(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010EBB RID: 69307 RVA: 0x00179364 File Offset: 0x00177564
		public virtual int GetProjectionModeMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionModeMinValue_12(base.GetCppThis());
		}

		// Token: 0x06010EBC RID: 69308
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTerrainPath_GetSource_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
		/// Note: This assigns a data object as the input terrain.
		/// To establish a pipeline connection, use
		/// SetSourceConnection() method.
		/// </summary>
		// Token: 0x06010EBD RID: 69309 RVA: 0x00179384 File Offset: 0x00177584
		public vtkImageData GetSource()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetSource_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010EBE RID: 69310
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTerrainPath_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EBF RID: 69311 RVA: 0x001793F4 File Offset: 0x001775F4
		public override int IsA(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06010EC0 RID: 69312
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProjectedTerrainPath_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EC1 RID: 69313 RVA: 0x00179414 File Offset: 0x00177614
		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_IsTypeOf_15(type);
		}

		// Token: 0x06010EC2 RID: 69314
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTerrainPath_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EC3 RID: 69315 RVA: 0x00179430 File Offset: 0x00177630
		public new vtkProjectedTerrainPath NewInstance()
		{
			vtkProjectedTerrainPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010EC4 RID: 69316
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProjectedTerrainPath_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x06010EC5 RID: 69317 RVA: 0x0017948C File Offset: 0x0017768C
		public new static vtkProjectedTerrainPath SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTerrainPath vtkProjectedTerrainPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTerrainPath = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTerrainPath.Register(null);
				}
			}
			return vtkProjectedTerrainPath;
		}

		// Token: 0x06010EC6 RID: 69318
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetHeightOffset_19(HandleRef pThis, double _arg);

		/// <summary>
		/// This is the height above (or below) the terrain that the projected
		/// path should be. Positive values indicate distances above the terrain;
		/// negative values indicate distances below the terrain.
		/// </summary>
		// Token: 0x06010EC7 RID: 69319 RVA: 0x0017950B File Offset: 0x0017770B
		public virtual void SetHeightOffset(double _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetHeightOffset_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010EC8 RID: 69320
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetHeightTolerance_20(HandleRef pThis, double _arg);

		/// <summary>
		/// This is the allowable variation in the altitude of the path
		/// with respect to the variation in the terrain. It only comes
		/// into play if the hug projection mode is enabled.
		/// </summary>
		// Token: 0x06010EC9 RID: 69321 RVA: 0x0017951B File Offset: 0x0017771B
		public virtual void SetHeightTolerance(double _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetHeightTolerance_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06010ECA RID: 69322
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetMaximumNumberOfLines_21(HandleRef pThis, long _arg);

		/// <summary>
		/// This instance variable can be used to limit the total number of line
		/// segments created during subdivision. Note that the number of input line
		/// segments will be the minimum number that cab be output.
		/// </summary>
		// Token: 0x06010ECB RID: 69323 RVA: 0x0017952B File Offset: 0x0017772B
		public virtual void SetMaximumNumberOfLines(long _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetMaximumNumberOfLines_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06010ECC RID: 69324
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetProjectionMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010ECD RID: 69325 RVA: 0x0017953B File Offset: 0x0017773B
		public virtual void SetProjectionMode(int _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionMode_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06010ECE RID: 69326
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToHug_23(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010ECF RID: 69327 RVA: 0x0017954B File Offset: 0x0017774B
		public void SetProjectionModeToHug()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToHug_23(base.GetCppThis());
		}

		// Token: 0x06010ED0 RID: 69328
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_24(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010ED1 RID: 69329 RVA: 0x0017955A File Offset: 0x0017775A
		public void SetProjectionModeToNonOccluded()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_24(base.GetCppThis());
		}

		// Token: 0x06010ED2 RID: 69330
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToSimple_25(HandleRef pThis);

		/// <summary>
		/// Determine how to control the projection process. Simple projection
		/// just projects the original polyline points. Non-occluded projection
		/// insures that the polyline does not intersect the terrain surface.
		/// Hug projection is similar to non-occulded projection except that
		/// produces a path that is nearly parallel to the terrain (within the
		/// user specified height tolerance).
		/// </summary>
		// Token: 0x06010ED3 RID: 69331 RVA: 0x00179569 File Offset: 0x00177769
		public void SetProjectionModeToSimple()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToSimple_25(base.GetCppThis());
		}

		// Token: 0x06010ED4 RID: 69332
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetSourceConnection_26(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
		/// Note: vtkImageData* is required
		/// </summary>
		// Token: 0x06010ED5 RID: 69333 RVA: 0x00179578 File Offset: 0x00177778
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetSourceConnection_26(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06010ED6 RID: 69334
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProjectedTerrainPath_SetSourceData_27(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
		/// Note: This assigns a data object as the input terrain.
		/// To establish a pipeline connection, use
		/// SetSourceConnection() method.
		/// </summary>
		// Token: 0x06010ED7 RID: 69335 RVA: 0x001795A8 File Offset: 0x001777A8
		public void SetSourceData(vtkImageData source)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetSourceData_27(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001385 RID: 4997
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTerrainPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001386 RID: 4998
		public new static readonly string MRClassNameKey = "class vtkProjectedTerrainPath";

		/// <summary>
		/// Specify the second input (the terrain) onto which the polyline(s) should be projected.
		/// Note: vtkImageData* is required
		/// </summary>
		// Token: 0x02000615 RID: 1557
		public enum HUG_PROJECTION_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001388 RID: 5000
			HUG_PROJECTION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001389 RID: 5001
			NONOCCLUDED_PROJECTION = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400138A RID: 5002
			SIMPLE_PROJECTION = 0
		}
	}
}
