using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimple3DCirclesStrategy
	/// </summary>
	/// <remarks>
	///    places vertices on circles in 3D
	///
	///
	/// Places vertices on circles depending on the graph vertices hierarchy level.
	/// The source graph could be vtkDirectedAcyclicGraph or vtkDirectedGraph if MarkedStartPoints array
	/// was added. The algorithm collects the standalone points, too and take them to a separated circle.
	/// If method is FixedRadiusMethod, the radius of the circles will be equal. If method is
	/// FixedDistanceMethod, the distance between the points on circles will be equal.
	///
	/// In first step initial points are searched. A point is initial, if its in degree equal zero and
	/// out degree is greater than zero (or marked by MarkedStartVertices and out degree is greater than
	/// zero). Independent vertices (in and out degree equal zero) are collected separately. In second
	/// step the hierarchical level is generated for every vertex. In third step the hierarchical order
	/// is generated. If a vertex has no hierarchical level and it is not independent, the graph has loop
	/// so the algorithm exit with error message. Finally the vertices positions are calculated by the
	/// hierarchical order and by the vertices hierarchy levels.
	///
	/// @par Thanks:
	/// Ferenc Nasztanovics, naszta@naszta.hu, Budapest University of Technology and Economics,
	/// Department of Structural Mechanics
	///
	/// @par References:
	/// in 3D rotation was used: http://en.citizendium.org/wiki/Rotation_matrix
	/// </remarks>
	// Token: 0x02000299 RID: 665
	public class vtkSimple3DCirclesStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007854 RID: 30804 RVA: 0x000AD6FF File Offset: 0x000AB8FF
		static vtkSimple3DCirclesStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimple3DCirclesStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple3DCirclesStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007855 RID: 30805 RVA: 0x000AD727 File Offset: 0x000AB927
		public vtkSimple3DCirclesStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007856 RID: 30806
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007857 RID: 30807 RVA: 0x000AD738 File Offset: 0x000AB938
		public new static vtkSimple3DCirclesStrategy New()
		{
			vtkSimple3DCirclesStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007858 RID: 30808 RVA: 0x000AD78C File Offset: 0x000AB98C
		public vtkSimple3DCirclesStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007859 RID: 30809 RVA: 0x000AD7D0 File Offset: 0x000AB9D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600785A RID: 30810
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOff_01(HandleRef pThis);

		/// <summary>
		/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
		/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
		/// should turn off AutoHeight.
		/// </summary>
		// Token: 0x0600785B RID: 30811 RVA: 0x000AD7DB File Offset: 0x000AB9DB
		public virtual void AutoHeightOff()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_AutoHeightOff_01(base.GetCppThis());
		}

		// Token: 0x0600785C RID: 30812
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_AutoHeightOn_02(HandleRef pThis);

		/// <summary>
		/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
		/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
		/// should turn off AutoHeight.
		/// </summary>
		// Token: 0x0600785D RID: 30813 RVA: 0x000AD7EA File Offset: 0x000AB9EA
		public virtual void AutoHeightOn()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_AutoHeightOn_02(base.GetCppThis());
		}

		// Token: 0x0600785E RID: 30814
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(HandleRef pThis);

		/// <summary>
		/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
		/// true, MarkedStartVertices won't be used. In this case the input graph must be
		/// vtkDirectedAcyclicGraph (Default: false).
		/// </summary>
		// Token: 0x0600785F RID: 30815 RVA: 0x000AD7F9 File Offset: 0x000AB9F9
		public virtual void ForceToUseUniversalStartPointsFinderOff()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOff_03(base.GetCppThis());
		}

		// Token: 0x06007860 RID: 30816
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(HandleRef pThis);

		/// <summary>
		/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
		/// true, MarkedStartVertices won't be used. In this case the input graph must be
		/// vtkDirectedAcyclicGraph (Default: false).
		/// </summary>
		// Token: 0x06007861 RID: 30817 RVA: 0x000AD808 File Offset: 0x000ABA08
		public virtual void ForceToUseUniversalStartPointsFinderOn()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_ForceToUseUniversalStartPointsFinderOn_04(base.GetCppThis());
		}

		// Token: 0x06007862 RID: 30818
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple3DCirclesStrategy_GetAutoHeight_05(HandleRef pThis);

		/// <summary>
		/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
		/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
		/// should turn off AutoHeight.
		/// </summary>
		// Token: 0x06007863 RID: 30819 RVA: 0x000AD818 File Offset: 0x000ABA18
		public virtual int GetAutoHeight()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetAutoHeight_05(base.GetCppThis());
		}

		// Token: 0x06007864 RID: 30820
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetDirection_06(HandleRef pThis);

		/// <summary>
		/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
		/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
		/// </summary>
		// Token: 0x06007865 RID: 30821 RVA: 0x000AD838 File Offset: 0x000ABA38
		public virtual double[] GetDirection()
		{
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007866 RID: 30822
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_GetDirection_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
		/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
		/// </summary>
		// Token: 0x06007867 RID: 30823 RVA: 0x000AD880 File Offset: 0x000ABA80
		public virtual void GetDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007868 RID: 30824
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_GetDirection_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
		/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
		/// </summary>
		// Token: 0x06007869 RID: 30825 RVA: 0x000AD892 File Offset: 0x000ABA92
		public virtual void GetDirection(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetDirection_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600786A RID: 30826
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(HandleRef pThis);

		/// <summary>
		/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
		/// true, MarkedStartVertices won't be used. In this case the input graph must be
		/// vtkDirectedAcyclicGraph (Default: false).
		/// </summary>
		// Token: 0x0600786B RID: 30827 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
		public virtual int GetForceToUseUniversalStartPointsFinder()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetForceToUseUniversalStartPointsFinder_09(base.GetCppThis());
		}

		// Token: 0x0600786C RID: 30828
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple3DCirclesStrategy_GetHeight_10(HandleRef pThis);

		/// <summary>
		/// Set or get the vertical (local z) distance between the circles. If AutoHeight is on, this is
		/// the minimal height between the circle layers
		/// </summary>
		// Token: 0x0600786D RID: 30829 RVA: 0x000AD8C4 File Offset: 0x000ABAC4
		public virtual double GetHeight()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHeight_10(base.GetCppThis());
		}

		// Token: 0x0600786E RID: 30830
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get hierarchical layers id by vertices (An usual vertex's layer id is greater or equal
		/// to zero. If a vertex is standalone, its layer id is -2.) If no HierarchicalLayers array is
		/// defined, vtkSimple3DCirclesStrategy will generate it automatically (default).
		/// </summary>
		// Token: 0x0600786F RID: 30831 RVA: 0x000AD8E4 File Offset: 0x000ABAE4
		public virtual vtkIntArray GetHierarchicalLayers()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHierarchicalLayers_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x06007870 RID: 30832
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get hierarchical ordering of vertices (The array starts from the first vertex's id. All
		/// id must be greater or equal to zero!) If no HierarchicalOrder is defined,
		/// vtkSimple3DCirclesStrategy will generate it automatically (default).
		/// </summary>
		// Token: 0x06007871 RID: 30833 RVA: 0x000AD954 File Offset: 0x000ABB54
		public virtual vtkIdTypeArray GetHierarchicalOrder()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetHierarchicalOrder_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06007872 RID: 30834
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get initial vertices. If MarkedStartVertices is added, loop is accepted in the graph.
		/// (If all of the loop start vertices are marked in MarkedStartVertices array.)
		/// MarkedStartVertices size must be equal with the number of the vertices in the graph. Start
		/// vertices must be marked by MarkedValue. (E.g.: if MarkedValue=3 and MarkedStartPoints is { 0,
		/// 3, 5, 3 }, the start points ids will be {1,3}.) )
		/// </summary>
		// Token: 0x06007873 RID: 30835 RVA: 0x000AD9C4 File Offset: 0x000ABBC4
		public virtual vtkAbstractArray GetMarkedStartVertices()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMarkedStartVertices_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x06007874 RID: 30836
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetMarkedValue_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or get MarkedValue. See: MarkedStartVertices.
		/// </summary>
		// Token: 0x06007875 RID: 30837 RVA: 0x000ADA34 File Offset: 0x000ABC34
		public virtual vtkVariant GetMarkedValue()
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMarkedValue_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007876 RID: 30838
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple3DCirclesStrategy_GetMethod_15(HandleRef pThis);

		/// <summary>
		/// Set or get circle generating method (FixedRadiusMethod/FixedDistanceMethod). Default is
		/// FixedRadiusMethod.
		/// </summary>
		// Token: 0x06007877 RID: 30839 RVA: 0x000ADA90 File Offset: 0x000ABC90
		public virtual int GetMethod()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMethod_15(base.GetCppThis());
		}

		// Token: 0x06007878 RID: 30840
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple3DCirclesStrategy_GetMinimumDegree_16(HandleRef pThis);

		/// <summary>
		/// Set or get minimum degree (used by auto height). There is no separated minimum degree, so
		/// minimum radian will be changed.
		/// </summary>
		// Token: 0x06007879 RID: 30841 RVA: 0x000ADAB0 File Offset: 0x000ABCB0
		public virtual double GetMinimumDegree()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMinimumDegree_16(base.GetCppThis());
		}

		// Token: 0x0600787A RID: 30842
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple3DCirclesStrategy_GetMinimumRadian_17(HandleRef pThis);

		/// <summary>
		/// Set or get minimum radian (used by auto height).
		/// </summary>
		// Token: 0x0600787B RID: 30843 RVA: 0x000ADAD0 File Offset: 0x000ABCD0
		public virtual double GetMinimumRadian()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetMinimumRadian_17(base.GetCppThis());
		}

		// Token: 0x0600787C RID: 30844
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600787D RID: 30845 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0600787E RID: 30846
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600787F RID: 30847 RVA: 0x000ADB10 File Offset: 0x000ABD10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06007880 RID: 30848
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_GetOrigin_20(HandleRef pThis);

		/// <summary>
		/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
		/// </summary>
		// Token: 0x06007881 RID: 30849 RVA: 0x000ADB2C File Offset: 0x000ABD2C
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007882 RID: 30850
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
		/// </summary>
		// Token: 0x06007883 RID: 30851 RVA: 0x000ADB74 File Offset: 0x000ABD74
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007884 RID: 30852
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_GetOrigin_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
		/// </summary>
		// Token: 0x06007885 RID: 30853 RVA: 0x000ADB86 File Offset: 0x000ABD86
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetOrigin_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06007886 RID: 30854
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSimple3DCirclesStrategy_GetRadius_23(HandleRef pThis);

		/// <summary>
		/// If Method is FixedRadiusMethod: Set or get the radius of the circles.
		/// If Method is FixedDistanceMethod: Set or get the distance of the points in the circle.
		/// </summary>
		// Token: 0x06007887 RID: 30855 RVA: 0x000ADB98 File Offset: 0x000ABD98
		public virtual double GetRadius()
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_GetRadius_23(base.GetCppThis());
		}

		// Token: 0x06007888 RID: 30856
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple3DCirclesStrategy_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007889 RID: 30857 RVA: 0x000ADBB8 File Offset: 0x000ABDB8
		public override int IsA(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600788A RID: 30858
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimple3DCirclesStrategy_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600788B RID: 30859 RVA: 0x000ADBD8 File Offset: 0x000ABDD8
		public new static int IsTypeOf(string type)
		{
			return vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_IsTypeOf_25(type);
		}

		// Token: 0x0600788C RID: 30860
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_Layout_26(HandleRef pThis);

		/// <summary>
		/// Standard layout method
		/// </summary>
		// Token: 0x0600788D RID: 30861 RVA: 0x000ADBF2 File Offset: 0x000ABDF2
		public override void Layout()
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_Layout_26(base.GetCppThis());
		}

		// Token: 0x0600788E RID: 30862
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600788F RID: 30863 RVA: 0x000ADC04 File Offset: 0x000ABE04
		public new vtkSimple3DCirclesStrategy NewInstance()
		{
			vtkSimple3DCirclesStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007890 RID: 30864
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimple3DCirclesStrategy_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007891 RID: 30865 RVA: 0x000ADC60 File Offset: 0x000ABE60
		public new static vtkSimple3DCirclesStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSimple3DCirclesStrategy vtkSimple3DCirclesStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimple3DCirclesStrategy = (vtkSimple3DCirclesStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimple3DCirclesStrategy.Register(null);
				}
			}
			return vtkSimple3DCirclesStrategy;
		}

		// Token: 0x06007892 RID: 30866
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetAutoHeight_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get auto height (Default: false). If AutoHeight is true, (r(i+1) - r(i-1))/Height will
		/// be smaller than tan(MinimumRadian). If you want equal distances and parallel circles, you
		/// should turn off AutoHeight.
		/// </summary>
		// Token: 0x06007893 RID: 30867 RVA: 0x000ADCDF File Offset: 0x000ABEDF
		public virtual void SetAutoHeight(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetAutoHeight_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06007894 RID: 30868
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetDirection_31(HandleRef pThis, double dx, double dy, double dz);

		/// <summary>
		/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
		/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
		/// </summary>
		// Token: 0x06007895 RID: 30869 RVA: 0x000ADCEF File Offset: 0x000ABEEF
		public virtual void SetDirection(double dx, double dy, double dz)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetDirection_31(base.GetCppThis(), dx, dy, dz);
		}

		// Token: 0x06007896 RID: 30870
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetDirection_32(HandleRef pThis, IntPtr d);

		/// <summary>
		/// Set or get the normal vector of the circles plain. The height is growing in this direction. The
		/// direction must not be zero vector. The default vector is (0.0,0.0,1.0)
		/// </summary>
		// Token: 0x06007897 RID: 30871 RVA: 0x000ADD01 File Offset: 0x000ABF01
		public virtual void SetDirection(IntPtr d)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetDirection_32(base.GetCppThis(), d);
		}

		// Token: 0x06007898 RID: 30872
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get ForceToUseUniversalStartPointsFinder. If ForceToUseUniversalStartPointsFinder is
		/// true, MarkedStartVertices won't be used. In this case the input graph must be
		/// vtkDirectedAcyclicGraph (Default: false).
		/// </summary>
		// Token: 0x06007899 RID: 30873 RVA: 0x000ADD11 File Offset: 0x000ABF11
		public virtual void SetForceToUseUniversalStartPointsFinder(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetForceToUseUniversalStartPointsFinder_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600789A RID: 30874
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetGraph_34(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// Set graph (warning: HierarchicalOrder and HierarchicalLayers will set to zero. These reference
		/// counts will be decreased!)
		/// </summary>
		// Token: 0x0600789B RID: 30875 RVA: 0x000ADD24 File Offset: 0x000ABF24
		public override void SetGraph(vtkGraph graph)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetGraph_34(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		// Token: 0x0600789C RID: 30876
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetHeight_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set or get the vertical (local z) distance between the circles. If AutoHeight is on, this is
		/// the minimal height between the circle layers
		/// </summary>
		// Token: 0x0600789D RID: 30877 RVA: 0x000ADD53 File Offset: 0x000ABF53
		public virtual void SetHeight(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHeight_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600789E RID: 30878
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalLayers_36(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set or get hierarchical layers id by vertices (An usual vertex's layer id is greater or equal
		/// to zero. If a vertex is standalone, its layer id is -2.) If no HierarchicalLayers array is
		/// defined, vtkSimple3DCirclesStrategy will generate it automatically (default).
		/// </summary>
		// Token: 0x0600789F RID: 30879 RVA: 0x000ADD64 File Offset: 0x000ABF64
		public virtual void SetHierarchicalLayers(vtkIntArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHierarchicalLayers_36(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060078A0 RID: 30880
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetHierarchicalOrder_37(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set or get hierarchical ordering of vertices (The array starts from the first vertex's id. All
		/// id must be greater or equal to zero!) If no HierarchicalOrder is defined,
		/// vtkSimple3DCirclesStrategy will generate it automatically (default).
		/// </summary>
		// Token: 0x060078A1 RID: 30881 RVA: 0x000ADD94 File Offset: 0x000ABF94
		public virtual void SetHierarchicalOrder(vtkIdTypeArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetHierarchicalOrder_37(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060078A2 RID: 30882
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetMarkedStartVertices_38(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set or get initial vertices. If MarkedStartVertices is added, loop is accepted in the graph.
		/// (If all of the loop start vertices are marked in MarkedStartVertices array.)
		/// MarkedStartVertices size must be equal with the number of the vertices in the graph. Start
		/// vertices must be marked by MarkedValue. (E.g.: if MarkedValue=3 and MarkedStartPoints is { 0,
		/// 3, 5, 3 }, the start points ids will be {1,3}.) )
		/// </summary>
		// Token: 0x060078A3 RID: 30883 RVA: 0x000ADDC4 File Offset: 0x000ABFC4
		public virtual void SetMarkedStartVertices(vtkAbstractArray _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMarkedStartVertices_38(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060078A4 RID: 30884
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetMarkedValue_39(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set or get MarkedValue. See: MarkedStartVertices.
		/// </summary>
		// Token: 0x060078A5 RID: 30885 RVA: 0x000ADDF4 File Offset: 0x000ABFF4
		public virtual void SetMarkedValue(vtkVariant _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMarkedValue_39(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060078A6 RID: 30886
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetMethod_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get circle generating method (FixedRadiusMethod/FixedDistanceMethod). Default is
		/// FixedRadiusMethod.
		/// </summary>
		// Token: 0x060078A7 RID: 30887 RVA: 0x000ADE23 File Offset: 0x000AC023
		public virtual void SetMethod(int _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMethod_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060078A8 RID: 30888
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetMinimumDegree_41(HandleRef pThis, double degree);

		/// <summary>
		/// Set or get minimum degree (used by auto height). There is no separated minimum degree, so
		/// minimum radian will be changed.
		/// </summary>
		// Token: 0x060078A9 RID: 30889 RVA: 0x000ADE33 File Offset: 0x000AC033
		public virtual void SetMinimumDegree(double degree)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMinimumDegree_41(base.GetCppThis(), degree);
		}

		// Token: 0x060078AA RID: 30890
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetMinimumRadian_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Set or get minimum radian (used by auto height).
		/// </summary>
		// Token: 0x060078AB RID: 30891 RVA: 0x000ADE43 File Offset: 0x000AC043
		public virtual void SetMinimumRadian(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetMinimumRadian_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060078AC RID: 30892
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
		/// </summary>
		// Token: 0x060078AD RID: 30893 RVA: 0x000ADE53 File Offset: 0x000AC053
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetOrigin_43(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060078AE RID: 30894
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetOrigin_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set or get the origin of the geometry. This is the center of the first circle. SetOrigin(x,y,z)
		/// </summary>
		// Token: 0x060078AF RID: 30895 RVA: 0x000ADE65 File Offset: 0x000AC065
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetOrigin_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060078B0 RID: 30896
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimple3DCirclesStrategy_SetRadius_45(HandleRef pThis, double _arg);

		/// <summary>
		/// If Method is FixedRadiusMethod: Set or get the radius of the circles.
		/// If Method is FixedDistanceMethod: Set or get the distance of the points in the circle.
		/// </summary>
		// Token: 0x060078B1 RID: 30897 RVA: 0x000ADE75 File Offset: 0x000AC075
		public virtual void SetRadius(double _arg)
		{
			vtkSimple3DCirclesStrategy.vtkSimple3DCirclesStrategy_SetRadius_45(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A40 RID: 2624
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimple3DCirclesStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A41 RID: 2625
		public new static readonly string MRClassNameKey = "class vtkSimple3DCirclesStrategy";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200029A RID: 666
		public enum FixedDistanceMethod_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000A43 RID: 2627
			FixedDistanceMethod = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000A44 RID: 2628
			FixedRadiusMethod = 0
		}
	}
}
