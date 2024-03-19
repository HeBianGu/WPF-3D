using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSphereTreeFilter
	/// </summary>
	/// <remarks>
	///  represent a sphere tree as vtkPolyData
	///
	/// vtkSphereTreeFilter is a filter that produces a vtkPolyData representation
	/// of a sphere tree (vtkSphereTree). Basically it generates a point, a scalar
	/// radius, and tree level number for the cell spheres and/or the different levels
	/// in the tree hierarchy (assuming that the hierarchy is built). The output
	/// can be glyphed using a filter like vtkGlyph3D to actually visualize the
	/// sphere tree. The primary use of this class is for visualization of sphere
	/// trees, and debugging the construction and use of sphere trees.
	///
	/// Additional capabilities include production of candidate spheres based on
	/// geometric queries. For example, queries based on a point, infinite line,
	/// and infinite plane are possible.
	///
	/// Note that this class may create a sphere tree, and then build it, for the
	/// input dataset to this filter (if no sphere tree is provided). If the user
	/// specifies a sphere tree, then the specified sphere tree is used. Thus the
	/// input to the filter is optional. Consequently this filter can act like a source,
	/// or as a filter in a pipeline.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSphereTree vtkPlaneCutter
	/// </seealso>
	// Token: 0x0200099D RID: 2461
	public class vtkSphereTreeFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019B03 RID: 105219 RVA: 0x0023B573 File Offset: 0x00239773
		static vtkSphereTreeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereTreeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereTreeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019B04 RID: 105220 RVA: 0x0023B59B File Offset: 0x0023979B
		public vtkSphereTreeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019B05 RID: 105221
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the sphere tree filter.
		/// </summary>
		// Token: 0x06019B06 RID: 105222 RVA: 0x0023B5AC File Offset: 0x002397AC
		public new static vtkSphereTreeFilter New()
		{
			vtkSphereTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the sphere tree filter.
		/// </summary>
		// Token: 0x06019B07 RID: 105223 RVA: 0x0023B600 File Offset: 0x00239800
		public vtkSphereTreeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereTreeFilter.vtkSphereTreeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019B08 RID: 105224 RVA: 0x0023B644 File Offset: 0x00239844
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019B09 RID: 105225
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_GetExtractionMode_01(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B0A RID: 105226 RVA: 0x0023B650 File Offset: 0x00239850
		public virtual int GetExtractionMode()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetExtractionMode_01(base.GetCppThis());
		}

		// Token: 0x06019B0B RID: 105227
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_GetExtractionModeAsString_02(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B0C RID: 105228 RVA: 0x0023B670 File Offset: 0x00239870
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkSphereTreeFilter.vtkSphereTreeFilter_GetExtractionModeAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019B0D RID: 105229
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_GetLevel_03(HandleRef pThis);

		/// <summary>
		/// Specify the level of the tree to extract (used when ExtractionMode is
		/// set to Levels). A value of (-1) means all levels. Note that level 0 is
		/// the root of the sphere tree. By default all levels are extracted. Note
		/// that if TreeHierarchy is off, then it is only possible to extract leaf
		/// spheres (i.e., spheres for each cell of the associated dataset).
		/// </summary>
		// Token: 0x06019B0E RID: 105230 RVA: 0x0023B6AC File Offset: 0x002398AC
		public virtual int GetLevel()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetLevel_03(base.GetCppThis());
		}

		// Token: 0x06019B0F RID: 105231
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_GetLevelMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the level of the tree to extract (used when ExtractionMode is
		/// set to Levels). A value of (-1) means all levels. Note that level 0 is
		/// the root of the sphere tree. By default all levels are extracted. Note
		/// that if TreeHierarchy is off, then it is only possible to extract leaf
		/// spheres (i.e., spheres for each cell of the associated dataset).
		/// </summary>
		// Token: 0x06019B10 RID: 105232 RVA: 0x0023B6CC File Offset: 0x002398CC
		public virtual int GetLevelMaxValue()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetLevelMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06019B11 RID: 105233
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_GetLevelMinValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the level of the tree to extract (used when ExtractionMode is
		/// set to Levels). A value of (-1) means all levels. Note that level 0 is
		/// the root of the sphere tree. By default all levels are extracted. Note
		/// that if TreeHierarchy is off, then it is only possible to extract leaf
		/// spheres (i.e., spheres for each cell of the associated dataset).
		/// </summary>
		// Token: 0x06019B12 RID: 105234 RVA: 0x0023B6EC File Offset: 0x002398EC
		public virtual int GetLevelMinValue()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetLevelMinValue_05(base.GetCppThis());
		}

		// Token: 0x06019B13 RID: 105235
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSphereTreeFilter_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime because the sphere tree may have changed.
		/// </summary>
		// Token: 0x06019B14 RID: 105236 RVA: 0x0023B70C File Offset: 0x0023990C
		public override ulong GetMTime()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06019B15 RID: 105237
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_GetNormal_07(HandleRef pThis);

		/// <summary>
		/// Specify a plane used to extract spheres (used when ExtractionMode is set
		/// to Plane). The plane Normal plus Point define an infinite plane.
		/// </summary>
		// Token: 0x06019B16 RID: 105238 RVA: 0x0023B72C File Offset: 0x0023992C
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_GetNormal_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019B17 RID: 105239
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_GetNormal_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a plane used to extract spheres (used when ExtractionMode is set
		/// to Plane). The plane Normal plus Point define an infinite plane.
		/// </summary>
		// Token: 0x06019B18 RID: 105240 RVA: 0x0023B774 File Offset: 0x00239974
		public virtual void GetNormal(IntPtr data)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_GetNormal_08(base.GetCppThis(), data);
		}

		// Token: 0x06019B19 RID: 105241
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereTreeFilter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B1A RID: 105242 RVA: 0x0023B784 File Offset: 0x00239984
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06019B1B RID: 105243
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereTreeFilter_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B1C RID: 105244 RVA: 0x0023B7A4 File Offset: 0x002399A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06019B1D RID: 105245
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_GetPoint_11(HandleRef pThis);

		/// <summary>
		/// Specify a point used to extract one or more leaf spheres. This method is
		/// used when extracting spheres using a point, line, or plane.
		/// </summary>
		// Token: 0x06019B1E RID: 105246 RVA: 0x0023B7C0 File Offset: 0x002399C0
		public virtual double[] GetPoint()
		{
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_GetPoint_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019B1F RID: 105247
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_GetPoint_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point used to extract one or more leaf spheres. This method is
		/// used when extracting spheres using a point, line, or plane.
		/// </summary>
		// Token: 0x06019B20 RID: 105248 RVA: 0x0023B808 File Offset: 0x00239A08
		public virtual void GetPoint(IntPtr data)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_GetPoint_12(base.GetCppThis(), data);
		}

		// Token: 0x06019B21 RID: 105249
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_GetRay_13(HandleRef pThis);

		/// <summary>
		/// Specify a line used to extract spheres (used when ExtractionMode is set
		/// to Line). The Ray plus Point define an infinite line. The ray is a
		/// vector defining the direction of the line.
		/// </summary>
		// Token: 0x06019B22 RID: 105250 RVA: 0x0023B818 File Offset: 0x00239A18
		public virtual double[] GetRay()
		{
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_GetRay_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019B23 RID: 105251
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_GetRay_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a line used to extract spheres (used when ExtractionMode is set
		/// to Line). The Ray plus Point define an infinite line. The ray is a
		/// vector defining the direction of the line.
		/// </summary>
		// Token: 0x06019B24 RID: 105252 RVA: 0x0023B860 File Offset: 0x00239A60
		public virtual void GetRay(IntPtr data)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_GetRay_14(base.GetCppThis(), data);
		}

		// Token: 0x06019B25 RID: 105253
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_GetSphereTree_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify and retrieve the sphere tree.
		/// </summary>
		// Token: 0x06019B26 RID: 105254 RVA: 0x0023B870 File Offset: 0x00239A70
		public virtual vtkSphereTree GetSphereTree()
		{
			vtkSphereTree vtkSphereTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_GetSphereTree_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereTree = (vtkSphereTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereTree.Register(null);
				}
			}
			return vtkSphereTree;
		}

		// Token: 0x06019B27 RID: 105255
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphereTreeFilter_GetTreeHierarchy_16(HandleRef pThis);

		/// <summary>
		/// Enable or disable the building and generation of the sphere tree
		/// hierarchy. The hierarchy represents different levels in the tree
		/// and enables rapid traversal of the tree.
		/// </summary>
		// Token: 0x06019B28 RID: 105256 RVA: 0x0023B8E0 File Offset: 0x00239AE0
		public virtual bool GetTreeHierarchy()
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_GetTreeHierarchy_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06019B29 RID: 105257
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B2A RID: 105258 RVA: 0x0023B908 File Offset: 0x00239B08
		public override int IsA(string type)
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06019B2B RID: 105259
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereTreeFilter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B2C RID: 105260 RVA: 0x0023B928 File Offset: 0x00239B28
		public new static int IsTypeOf(string type)
		{
			return vtkSphereTreeFilter.vtkSphereTreeFilter_IsTypeOf_18(type);
		}

		// Token: 0x06019B2D RID: 105261
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B2E RID: 105262 RVA: 0x0023B944 File Offset: 0x00239B44
		public new vtkSphereTreeFilter NewInstance()
		{
			vtkSphereTreeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019B2F RID: 105263
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereTreeFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type related macros and PrintSelf() method.
		/// </summary>
		// Token: 0x06019B30 RID: 105264 RVA: 0x0023B9A0 File Offset: 0x00239BA0
		public new static vtkSphereTreeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSphereTreeFilter vtkSphereTreeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereTreeFilter.vtkSphereTreeFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereTreeFilter = (vtkSphereTreeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereTreeFilter.Register(null);
				}
			}
			return vtkSphereTreeFilter;
		}

		// Token: 0x06019B31 RID: 105265
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetExtractionMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B32 RID: 105266 RVA: 0x0023BA1F File Offset: 0x00239C1F
		public virtual void SetExtractionMode(int _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetExtractionMode_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B33 RID: 105267
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetExtractionModeToLevels_23(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B34 RID: 105268 RVA: 0x0023BA2F File Offset: 0x00239C2F
		public void SetExtractionModeToLevels()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetExtractionModeToLevels_23(base.GetCppThis());
		}

		// Token: 0x06019B35 RID: 105269
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetExtractionModeToLine_24(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B36 RID: 105270 RVA: 0x0023BA3E File Offset: 0x00239C3E
		public void SetExtractionModeToLine()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetExtractionModeToLine_24(base.GetCppThis());
		}

		// Token: 0x06019B37 RID: 105271
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetExtractionModeToPlane_25(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B38 RID: 105272 RVA: 0x0023BA4D File Offset: 0x00239C4D
		public void SetExtractionModeToPlane()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetExtractionModeToPlane_25(base.GetCppThis());
		}

		// Token: 0x06019B39 RID: 105273
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetExtractionModeToPoint_26(HandleRef pThis);

		/// <summary>
		/// Specify what information this filter is to extract from the sphere
		/// tree. Options include: spheres that make up one or more levels; spheres
		/// that intersect a specified plane; spheres that intersect a specified line;
		/// and spheres that intersect a specified point. What is extracted are sphere
		/// centers, a radius, and an optional level. By default the specified levels
		/// are extracted.
		/// </summary>
		// Token: 0x06019B3A RID: 105274 RVA: 0x0023BA5C File Offset: 0x00239C5C
		public void SetExtractionModeToPoint()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetExtractionModeToPoint_26(base.GetCppThis());
		}

		// Token: 0x06019B3B RID: 105275
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetLevel_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the level of the tree to extract (used when ExtractionMode is
		/// set to Levels). A value of (-1) means all levels. Note that level 0 is
		/// the root of the sphere tree. By default all levels are extracted. Note
		/// that if TreeHierarchy is off, then it is only possible to extract leaf
		/// spheres (i.e., spheres for each cell of the associated dataset).
		/// </summary>
		// Token: 0x06019B3C RID: 105276 RVA: 0x0023BA6B File Offset: 0x00239C6B
		public virtual void SetLevel(int _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetLevel_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B3D RID: 105277
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetNormal_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a plane used to extract spheres (used when ExtractionMode is set
		/// to Plane). The plane Normal plus Point define an infinite plane.
		/// </summary>
		// Token: 0x06019B3E RID: 105278 RVA: 0x0023BA7B File Offset: 0x00239C7B
		public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetNormal_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019B3F RID: 105279
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetNormal_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a plane used to extract spheres (used when ExtractionMode is set
		/// to Plane). The plane Normal plus Point define an infinite plane.
		/// </summary>
		// Token: 0x06019B40 RID: 105280 RVA: 0x0023BA8D File Offset: 0x00239C8D
		public virtual void SetNormal(IntPtr _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetNormal_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B41 RID: 105281
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetPoint_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point used to extract one or more leaf spheres. This method is
		/// used when extracting spheres using a point, line, or plane.
		/// </summary>
		// Token: 0x06019B42 RID: 105282 RVA: 0x0023BA9D File Offset: 0x00239C9D
		public virtual void SetPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetPoint_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019B43 RID: 105283
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetPoint_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point used to extract one or more leaf spheres. This method is
		/// used when extracting spheres using a point, line, or plane.
		/// </summary>
		// Token: 0x06019B44 RID: 105284 RVA: 0x0023BAAF File Offset: 0x00239CAF
		public virtual void SetPoint(IntPtr _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetPoint_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B45 RID: 105285
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetRay_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a line used to extract spheres (used when ExtractionMode is set
		/// to Line). The Ray plus Point define an infinite line. The ray is a
		/// vector defining the direction of the line.
		/// </summary>
		// Token: 0x06019B46 RID: 105286 RVA: 0x0023BABF File Offset: 0x00239CBF
		public virtual void SetRay(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetRay_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06019B47 RID: 105287
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetRay_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a line used to extract spheres (used when ExtractionMode is set
		/// to Line). The Ray plus Point define an infinite line. The ray is a
		/// vector defining the direction of the line.
		/// </summary>
		// Token: 0x06019B48 RID: 105288 RVA: 0x0023BAD1 File Offset: 0x00239CD1
		public virtual void SetRay(IntPtr _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetRay_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06019B49 RID: 105289
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetSphereTree_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify and retrieve the sphere tree.
		/// </summary>
		// Token: 0x06019B4A RID: 105290 RVA: 0x0023BAE4 File Offset: 0x00239CE4
		public virtual void SetSphereTree(vtkSphereTree arg0)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetSphereTree_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019B4B RID: 105291
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_SetTreeHierarchy_35(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable or disable the building and generation of the sphere tree
		/// hierarchy. The hierarchy represents different levels in the tree
		/// and enables rapid traversal of the tree.
		/// </summary>
		// Token: 0x06019B4C RID: 105292 RVA: 0x0023BB13 File Offset: 0x00239D13
		public virtual void SetTreeHierarchy(bool _arg)
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_SetTreeHierarchy_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019B4D RID: 105293
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_TreeHierarchyOff_36(HandleRef pThis);

		/// <summary>
		/// Enable or disable the building and generation of the sphere tree
		/// hierarchy. The hierarchy represents different levels in the tree
		/// and enables rapid traversal of the tree.
		/// </summary>
		// Token: 0x06019B4E RID: 105294 RVA: 0x0023BB2B File Offset: 0x00239D2B
		public virtual void TreeHierarchyOff()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_TreeHierarchyOff_36(base.GetCppThis());
		}

		// Token: 0x06019B4F RID: 105295
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereTreeFilter_TreeHierarchyOn_37(HandleRef pThis);

		/// <summary>
		/// Enable or disable the building and generation of the sphere tree
		/// hierarchy. The hierarchy represents different levels in the tree
		/// and enables rapid traversal of the tree.
		/// </summary>
		// Token: 0x06019B50 RID: 105296 RVA: 0x0023BB3A File Offset: 0x00239D3A
		public virtual void TreeHierarchyOn()
		{
			vtkSphereTreeFilter.vtkSphereTreeFilter_TreeHierarchyOn_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BFF RID: 7167
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereTreeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C00 RID: 7168
		public new static readonly string MRClassNameKey = "class vtkSphereTreeFilter";
	}
}
