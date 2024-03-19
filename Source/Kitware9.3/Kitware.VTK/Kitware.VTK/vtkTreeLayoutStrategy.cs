using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeLayoutStrategy
	/// </summary>
	/// <remarks>
	///    hierarchical layout
	///
	///
	/// Assigns points to the nodes of a tree in either a standard or radial layout.
	/// The standard layout places each level on a horizontal line, while the
	/// radial layout places each level on a concentric circle.
	/// You may specify the sweep angle of the tree which constrains the tree
	/// to be contained within a wedge. Also, you may indicate the log scale of
	/// the tree, which diminishes the length of arcs at lower levels of the tree.
	/// Values near zero give a large proportion of the space to the tree levels
	/// near the root, while values near one give nearly equal proportions of space
	/// to all tree levels.
	///
	/// The user may also specify an array to use to indicate the distance from the
	/// root, either vertically (for standard layout) or radially
	/// (for radial layout).  You specify this with SetDistanceArrayName().
	///
	/// If the input is not a tree but a general graph, this strategy first extracts
	/// a tree from the graph using a breadth-first search starting at vertex ID 0.
	/// </remarks>
	// Token: 0x020002A1 RID: 673
	public class vtkTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007950 RID: 31056 RVA: 0x000AEE5D File Offset: 0x000AD05D
		static vtkTreeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007951 RID: 31057 RVA: 0x000AEE85 File Offset: 0x000AD085
		public vtkTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007952 RID: 31058
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007953 RID: 31059 RVA: 0x000AEE94 File Offset: 0x000AD094
		public new static vtkTreeLayoutStrategy New()
		{
			vtkTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007954 RID: 31060 RVA: 0x000AEEE8 File Offset: 0x000AD0E8
		public vtkTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007955 RID: 31061 RVA: 0x000AEF2C File Offset: 0x000AD12C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007956 RID: 31062
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetAngle_01(HandleRef pThis);

		/// <summary>
		/// The sweep angle of the tree.
		/// For a standard tree layout, this should be between 0 and 180.
		/// For a radial tree layout, this can be between 0 and 360.
		/// </summary>
		// Token: 0x06007957 RID: 31063 RVA: 0x000AEF38 File Offset: 0x000AD138
		public virtual double GetAngle()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngle_01(base.GetCppThis());
		}

		// Token: 0x06007958 RID: 31064
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetAngleMaxValue_02(HandleRef pThis);

		/// <summary>
		/// The sweep angle of the tree.
		/// For a standard tree layout, this should be between 0 and 180.
		/// For a radial tree layout, this can be between 0 and 360.
		/// </summary>
		// Token: 0x06007959 RID: 31065 RVA: 0x000AEF58 File Offset: 0x000AD158
		public virtual double GetAngleMaxValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngleMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600795A RID: 31066
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetAngleMinValue_03(HandleRef pThis);

		/// <summary>
		/// The sweep angle of the tree.
		/// For a standard tree layout, this should be between 0 and 180.
		/// For a radial tree layout, this can be between 0 and 360.
		/// </summary>
		// Token: 0x0600795B RID: 31067 RVA: 0x000AEF78 File Offset: 0x000AD178
		public virtual double GetAngleMinValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetAngleMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600795C RID: 31068
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLayoutStrategy_GetDistanceArrayName_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the array to use to determine the distance from the
		/// root.
		/// </summary>
		// Token: 0x0600795D RID: 31069 RVA: 0x000AEF98 File Offset: 0x000AD198
		public virtual string GetDistanceArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetDistanceArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600795E RID: 31070
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacing_05(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x0600795F RID: 31071 RVA: 0x000AEFD4 File Offset: 0x000AD1D4
		public virtual double GetLeafSpacing()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacing_05(base.GetCppThis());
		}

		// Token: 0x06007960 RID: 31072
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x06007961 RID: 31073 RVA: 0x000AEFF4 File Offset: 0x000AD1F4
		public virtual double GetLeafSpacingMaxValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacingMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06007962 RID: 31074
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(HandleRef pThis);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x06007963 RID: 31075 RVA: 0x000AF014 File Offset: 0x000AD214
		public virtual double GetLeafSpacingMinValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLeafSpacingMinValue_07(base.GetCppThis());
		}

		// Token: 0x06007964 RID: 31076
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetLogSpacingValue_08(HandleRef pThis);

		/// <summary>
		/// The spacing of tree levels. Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x06007965 RID: 31077 RVA: 0x000AF034 File Offset: 0x000AD234
		public virtual double GetLogSpacingValue()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetLogSpacingValue_08(base.GetCppThis());
		}

		// Token: 0x06007966 RID: 31078
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007967 RID: 31079 RVA: 0x000AF054 File Offset: 0x000AD254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06007968 RID: 31080
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007969 RID: 31081 RVA: 0x000AF074 File Offset: 0x000AD274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600796A RID: 31082
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeLayoutStrategy_GetRadial_11(HandleRef pThis);

		/// <summary>
		/// If set, the tree is laid out with levels on concentric circles
		/// around the root. If unset (default), the tree is laid out with
		/// levels on horizontal lines.
		/// </summary>
		// Token: 0x0600796B RID: 31083 RVA: 0x000AF090 File Offset: 0x000AD290
		public virtual bool GetRadial()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetRadial_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0600796C RID: 31084
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeLayoutStrategy_GetReverseEdges_12(HandleRef pThis);

		/// <summary>
		/// If set and the input is not a tree but a general graph, the filter
		/// will reverse the edges on the graph before extracting a tree using
		/// breadth first search.
		/// </summary>
		// Token: 0x0600796D RID: 31085 RVA: 0x000AF0B8 File Offset: 0x000AD2B8
		public virtual bool GetReverseEdges()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetReverseEdges_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600796E RID: 31086
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeLayoutStrategy_GetRotation_13(HandleRef pThis);

		/// <summary>
		/// The amount of counter-clockwise rotation to apply after the
		/// layout.
		/// </summary>
		// Token: 0x0600796F RID: 31087 RVA: 0x000AF0E0 File Offset: 0x000AD2E0
		public virtual double GetRotation()
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_GetRotation_13(base.GetCppThis());
		}

		// Token: 0x06007970 RID: 31088
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeLayoutStrategy_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007971 RID: 31089 RVA: 0x000AF100 File Offset: 0x000AD300
		public override int IsA(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06007972 RID: 31090
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeLayoutStrategy_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007973 RID: 31091 RVA: 0x000AF120 File Offset: 0x000AD320
		public new static int IsTypeOf(string type)
		{
			return vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_IsTypeOf_15(type);
		}

		// Token: 0x06007974 RID: 31092
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_Layout_16(HandleRef pThis);

		/// <summary>
		/// Perform the tree layout.
		/// </summary>
		// Token: 0x06007975 RID: 31093 RVA: 0x000AF13A File Offset: 0x000AD33A
		public override void Layout()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_Layout_16(base.GetCppThis());
		}

		// Token: 0x06007976 RID: 31094
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLayoutStrategy_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007977 RID: 31095 RVA: 0x000AF14C File Offset: 0x000AD34C
		public new vtkTreeLayoutStrategy NewInstance()
		{
			vtkTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007978 RID: 31096
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_RadialOff_19(HandleRef pThis);

		/// <summary>
		/// If set, the tree is laid out with levels on concentric circles
		/// around the root. If unset (default), the tree is laid out with
		/// levels on horizontal lines.
		/// </summary>
		// Token: 0x06007979 RID: 31097 RVA: 0x000AF1A6 File Offset: 0x000AD3A6
		public virtual void RadialOff()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_RadialOff_19(base.GetCppThis());
		}

		// Token: 0x0600797A RID: 31098
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_RadialOn_20(HandleRef pThis);

		/// <summary>
		/// If set, the tree is laid out with levels on concentric circles
		/// around the root. If unset (default), the tree is laid out with
		/// levels on horizontal lines.
		/// </summary>
		// Token: 0x0600797B RID: 31099 RVA: 0x000AF1B5 File Offset: 0x000AD3B5
		public virtual void RadialOn()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_RadialOn_20(base.GetCppThis());
		}

		// Token: 0x0600797C RID: 31100
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOff_21(HandleRef pThis);

		/// <summary>
		/// If set and the input is not a tree but a general graph, the filter
		/// will reverse the edges on the graph before extracting a tree using
		/// breadth first search.
		/// </summary>
		// Token: 0x0600797D RID: 31101 RVA: 0x000AF1C4 File Offset: 0x000AD3C4
		public virtual void ReverseEdgesOff()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_ReverseEdgesOff_21(base.GetCppThis());
		}

		// Token: 0x0600797E RID: 31102
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_ReverseEdgesOn_22(HandleRef pThis);

		/// <summary>
		/// If set and the input is not a tree but a general graph, the filter
		/// will reverse the edges on the graph before extracting a tree using
		/// breadth first search.
		/// </summary>
		// Token: 0x0600797F RID: 31103 RVA: 0x000AF1D3 File Offset: 0x000AD3D3
		public virtual void ReverseEdgesOn()
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_ReverseEdgesOn_22(base.GetCppThis());
		}

		// Token: 0x06007980 RID: 31104
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeLayoutStrategy_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007981 RID: 31105 RVA: 0x000AF1E4 File Offset: 0x000AD3E4
		public new static vtkTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkTreeLayoutStrategy vtkTreeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeLayoutStrategy = (vtkTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeLayoutStrategy.Register(null);
				}
			}
			return vtkTreeLayoutStrategy;
		}

		// Token: 0x06007982 RID: 31106
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetAngle_24(HandleRef pThis, double _arg);

		/// <summary>
		/// The sweep angle of the tree.
		/// For a standard tree layout, this should be between 0 and 180.
		/// For a radial tree layout, this can be between 0 and 360.
		/// </summary>
		// Token: 0x06007983 RID: 31107 RVA: 0x000AF263 File Offset: 0x000AD463
		public virtual void SetAngle(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetAngle_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06007984 RID: 31108
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetDistanceArrayName_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the array to use to determine the distance from the
		/// root.
		/// </summary>
		// Token: 0x06007985 RID: 31109 RVA: 0x000AF273 File Offset: 0x000AD473
		public virtual void SetDistanceArrayName(string _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetDistanceArrayName_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06007986 RID: 31110
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetLeafSpacing_26(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing of leaves.  Levels near one evenly space leaves
		/// with no gaps between subtrees.  Levels near zero creates
		/// large gaps between subtrees.
		/// </summary>
		// Token: 0x06007987 RID: 31111 RVA: 0x000AF283 File Offset: 0x000AD483
		public virtual void SetLeafSpacing(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetLeafSpacing_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06007988 RID: 31112
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetLogSpacingValue_27(HandleRef pThis, double _arg);

		/// <summary>
		/// The spacing of tree levels. Levels near zero give more space
		/// to levels near the root, while levels near one (the default)
		/// create evenly-spaced levels. Levels above one give more space
		/// to levels near the leaves.
		/// </summary>
		// Token: 0x06007989 RID: 31113 RVA: 0x000AF293 File Offset: 0x000AD493
		public virtual void SetLogSpacingValue(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetLogSpacingValue_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600798A RID: 31114
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetRadial_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, the tree is laid out with levels on concentric circles
		/// around the root. If unset (default), the tree is laid out with
		/// levels on horizontal lines.
		/// </summary>
		// Token: 0x0600798B RID: 31115 RVA: 0x000AF2A3 File Offset: 0x000AD4A3
		public virtual void SetRadial(bool _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetRadial_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600798C RID: 31116
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetReverseEdges_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set and the input is not a tree but a general graph, the filter
		/// will reverse the edges on the graph before extracting a tree using
		/// breadth first search.
		/// </summary>
		// Token: 0x0600798D RID: 31117 RVA: 0x000AF2BB File Offset: 0x000AD4BB
		public virtual void SetReverseEdges(bool _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetReverseEdges_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600798E RID: 31118
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeLayoutStrategy_SetRotation_30(HandleRef pThis, double _arg);

		/// <summary>
		/// The amount of counter-clockwise rotation to apply after the
		/// layout.
		/// </summary>
		// Token: 0x0600798F RID: 31119 RVA: 0x000AF2D3 File Offset: 0x000AD4D3
		public virtual void SetRotation(double _arg)
		{
			vtkTreeLayoutStrategy.vtkTreeLayoutStrategy_SetRotation_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A52 RID: 2642
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A53 RID: 2643
		public new static readonly string MRClassNameKey = "class vtkTreeLayoutStrategy";
	}
}
