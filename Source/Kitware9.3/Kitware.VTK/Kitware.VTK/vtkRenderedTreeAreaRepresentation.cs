using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedTreeAreaRepresentation
	///
	///
	/// </summary>
	// Token: 0x02000084 RID: 132
	public class vtkRenderedTreeAreaRepresentation : vtkRenderedRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600195E RID: 6494 RVA: 0x00028E17 File Offset: 0x00027017
		static vtkRenderedTreeAreaRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedTreeAreaRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedTreeAreaRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600195F RID: 6495 RVA: 0x00028E3F File Offset: 0x0002703F
		public vtkRenderedTreeAreaRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001960 RID: 6496
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001961 RID: 6497 RVA: 0x00028E50 File Offset: 0x00027050
		public new static vtkRenderedTreeAreaRepresentation New()
		{
			vtkRenderedTreeAreaRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001962 RID: 6498 RVA: 0x00028EA4 File Offset: 0x000270A4
		public vtkRenderedTreeAreaRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001963 RID: 6499 RVA: 0x00028EE8 File Offset: 0x000270E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001964 RID: 6500
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Apply the theme to this view.
		/// </summary>
		// Token: 0x06001965 RID: 6501 RVA: 0x00028EF4 File Offset: 0x000270F4
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x06001966 RID: 6502
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x06001967 RID: 6503 RVA: 0x00028F23 File Offset: 0x00027123
		public virtual void AreaLabelVisibilityOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOff_02(base.GetCppThis());
		}

		// Token: 0x06001968 RID: 6504
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x06001969 RID: 6505 RVA: 0x00028F32 File Offset: 0x00027132
		public virtual void AreaLabelVisibilityOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_AreaLabelVisibilityOn_03(base.GetCppThis());
		}

		// Token: 0x0600196A RID: 6506
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x0600196B RID: 6507 RVA: 0x00028F41 File Offset: 0x00027141
		public virtual void ColorAreasByArrayOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOff_04(base.GetCppThis());
		}

		// Token: 0x0600196C RID: 6508
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x0600196D RID: 6509 RVA: 0x00028F50 File Offset: 0x00027150
		public virtual void ColorAreasByArrayOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorAreasByArrayOn_05(base.GetCppThis());
		}

		// Token: 0x0600196E RID: 6510
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x0600196F RID: 6511 RVA: 0x00028F5F File Offset: 0x0002715F
		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOff_06(base.GetCppThis());
		}

		// Token: 0x06001970 RID: 6512
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001971 RID: 6513 RVA: 0x00028F6E File Offset: 0x0002716E
		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_ColorGraphEdgesByArrayOn_07(base.GetCppThis());
		}

		// Token: 0x06001972 RID: 6514
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x06001973 RID: 6515 RVA: 0x00028F80 File Offset: 0x00027180
		public string GetAreaColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaColorArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001974 RID: 6516
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(HandleRef pThis);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a rectangle in the treemap.
		/// </summary>
		// Token: 0x06001975 RID: 6517 RVA: 0x00028FBC File Offset: 0x000271BC
		public virtual string GetAreaHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaHoverArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001976 RID: 6518
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(HandleRef pThis);

		/// <summary>
		/// The array to use for area labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001977 RID: 6519 RVA: 0x00028FF8 File Offset: 0x000271F8
		public virtual string GetAreaLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelArrayName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001978 RID: 6520
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The mapper for rendering labels on areas. This may e.g. be
		/// vtkDynamic2DLabelMapper or vtkTreeMapLabelMapper.
		/// </summary>
		// Token: 0x06001979 RID: 6521 RVA: 0x00029034 File Offset: 0x00027234
		public virtual vtkLabeledDataMapper GetAreaLabelMapper()
		{
			vtkLabeledDataMapper vtkLabeledDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelMapper_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledDataMapper = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledDataMapper.Register(null);
				}
			}
			return vtkLabeledDataMapper;
		}

		// Token: 0x0600197A RID: 6522
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(HandleRef pThis);

		/// <summary>
		/// The array to use for area labeling priority.
		/// Default is "GraphVertexDegree".
		/// </summary>
		// Token: 0x0600197B RID: 6523 RVA: 0x000290A4 File Offset: 0x000272A4
		public virtual string GetAreaLabelPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelPriorityArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600197C RID: 6524
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text property for the area labels.
		/// </summary>
		// Token: 0x0600197D RID: 6525 RVA: 0x000290E0 File Offset: 0x000272E0
		public virtual vtkTextProperty GetAreaLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelTextProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600197E RID: 6526
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x0600197F RID: 6527 RVA: 0x00029150 File Offset: 0x00027350
		public virtual bool GetAreaLabelVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLabelVisibility_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06001980 RID: 6528
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy for producing spatial regions for the tree.
		/// </summary>
		// Token: 0x06001981 RID: 6529 RVA: 0x00029178 File Offset: 0x00027378
		public virtual vtkAreaLayoutStrategy GetAreaLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaLayoutStrategy_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		// Token: 0x06001982 RID: 6530
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(HandleRef pThis);

		/// <summary>
		/// The array to use for area sizes. Default is "size".
		/// </summary>
		// Token: 0x06001983 RID: 6531 RVA: 0x000291E8 File Offset: 0x000273E8
		public virtual string GetAreaSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaSizeArrayName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001984 RID: 6532
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The filter for converting areas to polydata. This may e.g. be
		/// vtkTreeMapToPolyData or vtkTreeRingToPolyData.
		/// The filter must take a vtkTree as input and produce vtkPolyData.
		/// </summary>
		// Token: 0x06001985 RID: 6533 RVA: 0x00029224 File Offset: 0x00027424
		public virtual vtkPolyDataAlgorithm GetAreaToPolyData()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetAreaToPolyData_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x06001986 RID: 6534
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06001987 RID: 6535 RVA: 0x00029294 File Offset: 0x00027494
		public virtual bool GetColorAreasByArray()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorAreasByArray_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06001988 RID: 6536
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001989 RID: 6537 RVA: 0x000292BC File Offset: 0x000274BC
		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0600198A RID: 6538
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(HandleRef pThis, int idx);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x0600198B RID: 6539 RVA: 0x000292E4 File Offset: 0x000274E4
		public virtual bool GetColorGraphEdgesByArray(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetColorGraphEdgesByArray_20(base.GetCppThis(), idx) != 0;
		}

		// Token: 0x0600198C RID: 6540
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(HandleRef pThis);

		/// <summary>
		/// Visibility of scalar bar actor for edges.
		/// </summary>
		// Token: 0x0600198D RID: 6541 RVA: 0x0002930C File Offset: 0x0002750C
		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetEdgeScalarBarVisibility_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0600198E RID: 6542
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(HandleRef pThis);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x0600198F RID: 6543 RVA: 0x00029334 File Offset: 0x00027534
		public virtual double GetGraphBundlingStrength()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_22(base.GetCppThis());
		}

		// Token: 0x06001990 RID: 6544
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(HandleRef pThis, int idx);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x06001991 RID: 6545 RVA: 0x00029354 File Offset: 0x00027554
		public virtual double GetGraphBundlingStrength(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphBundlingStrength_23(base.GetCppThis(), idx);
		}

		// Token: 0x06001992 RID: 6546
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06001993 RID: 6547 RVA: 0x00029374 File Offset: 0x00027574
		public virtual string GetGraphEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001994 RID: 6548
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(HandleRef pThis, int idx);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06001995 RID: 6549 RVA: 0x000293B0 File Offset: 0x000275B0
		public virtual string GetGraphEdgeColorArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeColorArrayName_25(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001996 RID: 6550
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(HandleRef pThis);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001997 RID: 6551 RVA: 0x000293EC File Offset: 0x000275EC
		public virtual string GetGraphEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001998 RID: 6552
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(HandleRef pThis, int idx);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001999 RID: 6553 RVA: 0x00029428 File Offset: 0x00027628
		public virtual string GetGraphEdgeLabelArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelArrayName_27(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600199A RID: 6554
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text property for the graph edge labels.
		/// </summary>
		// Token: 0x0600199B RID: 6555 RVA: 0x00029464 File Offset: 0x00027664
		public virtual vtkTextProperty GetGraphEdgeLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600199C RID: 6556
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text property for the graph edge labels.
		/// </summary>
		// Token: 0x0600199D RID: 6557 RVA: 0x000294D4 File Offset: 0x000276D4
		public virtual vtkTextProperty GetGraphEdgeLabelTextProperty(int idx)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelTextProperty_29(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600199E RID: 6558
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x0600199F RID: 6559 RVA: 0x00029544 File Offset: 0x00027744
		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_30(base.GetCppThis()) != 0;
		}

		// Token: 0x060019A0 RID: 6560
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(HandleRef pThis, int idx);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060019A1 RID: 6561 RVA: 0x0002956C File Offset: 0x0002776C
		public virtual bool GetGraphEdgeLabelVisibility(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphEdgeLabelVisibility_31(base.GetCppThis(), idx) != 0;
		}

		// Token: 0x060019A2 RID: 6562
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(HandleRef pThis);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a graph edge.
		/// </summary>
		// Token: 0x060019A3 RID: 6563 RVA: 0x00029594 File Offset: 0x00027794
		public virtual string GetGraphHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_32(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060019A4 RID: 6564
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(HandleRef pThis, int idx);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a graph edge.
		/// </summary>
		// Token: 0x060019A5 RID: 6565 RVA: 0x000295D0 File Offset: 0x000277D0
		public virtual string GetGraphHoverArrayName(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphHoverArrayName_33(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060019A6 RID: 6566
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(HandleRef pThis, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x060019A7 RID: 6567 RVA: 0x0002960C File Offset: 0x0002780C
		public virtual int GetGraphSplineType(int idx)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetGraphSplineType_34(base.GetCppThis(), idx);
		}

		// Token: 0x060019A8 RID: 6568
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBase_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019A9 RID: 6569 RVA: 0x0002962C File Offset: 0x0002782C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBase_35(base.GetCppThis(), type);
		}

		// Token: 0x060019AA RID: 6570
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBaseType_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019AB RID: 6571 RVA: 0x0002964C File Offset: 0x0002784C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetNumberOfGenerationsFromBaseType_36(type);
		}

		// Token: 0x060019AC RID: 6572
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_37(HandleRef pThis);

		/// <summary>
		/// Set the region shrink percentage between 0.0 and 1.0.
		/// </summary>
		// Token: 0x060019AD RID: 6573 RVA: 0x00029668 File Offset: 0x00027868
		public virtual double GetShrinkPercentage()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetShrinkPercentage_37(base.GetCppThis());
		}

		// Token: 0x060019AE RID: 6574
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_38(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060019AF RID: 6575 RVA: 0x00029688 File Offset: 0x00027888
		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GetUseRectangularCoordinates_38(base.GetCppThis()) != 0;
		}

		// Token: 0x060019B0 RID: 6576
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_39(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060019B1 RID: 6577 RVA: 0x000296AE File Offset: 0x000278AE
		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOff_39(base.GetCppThis());
		}

		// Token: 0x060019B2 RID: 6578
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_40(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060019B3 RID: 6579 RVA: 0x000296BD File Offset: 0x000278BD
		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_GraphEdgeLabelVisibilityOn_40(base.GetCppThis());
		}

		// Token: 0x060019B4 RID: 6580
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedTreeAreaRepresentation_IsA_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019B5 RID: 6581 RVA: 0x000296CC File Offset: 0x000278CC
		public override int IsA(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_IsA_41(base.GetCppThis(), type);
		}

		// Token: 0x060019B6 RID: 6582
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedTreeAreaRepresentation_IsTypeOf_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019B7 RID: 6583 RVA: 0x000296EC File Offset: 0x000278EC
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_IsTypeOf_42(type);
		}

		// Token: 0x060019B8 RID: 6584
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019B9 RID: 6585 RVA: 0x00029708 File Offset: 0x00027908
		public new vtkRenderedTreeAreaRepresentation NewInstance()
		{
			vtkRenderedTreeAreaRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_NewInstance_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060019BA RID: 6586
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedTreeAreaRepresentation_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060019BB RID: 6587 RVA: 0x00029764 File Offset: 0x00027964
		public new static vtkRenderedTreeAreaRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedTreeAreaRepresentation vtkRenderedTreeAreaRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedTreeAreaRepresentation = (vtkRenderedTreeAreaRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedTreeAreaRepresentation.Register(null);
				}
			}
			return vtkRenderedTreeAreaRepresentation;
		}

		// Token: 0x060019BC RID: 6588
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x060019BD RID: 6589 RVA: 0x000297E3 File Offset: 0x000279E3
		public void SetAreaColorArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaColorArrayName_46(base.GetCppThis(), name);
		}

		// Token: 0x060019BE RID: 6590
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a rectangle in the treemap.
		/// </summary>
		// Token: 0x060019BF RID: 6591 RVA: 0x000297F3 File Offset: 0x000279F3
		public virtual void SetAreaHoverArrayName(string _arg)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaHoverArrayName_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060019C0 RID: 6592
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area labeling.  Default is "label".
		/// </summary>
		// Token: 0x060019C1 RID: 6593 RVA: 0x00029803 File Offset: 0x00027A03
		public virtual void SetAreaLabelArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelArrayName_48(base.GetCppThis(), name);
		}

		// Token: 0x060019C2 RID: 6594
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_49(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// The mapper for rendering labels on areas. This may e.g. be
		/// vtkDynamic2DLabelMapper or vtkTreeMapLabelMapper.
		/// </summary>
		// Token: 0x060019C3 RID: 6595 RVA: 0x00029814 File Offset: 0x00027A14
		public virtual void SetAreaLabelMapper(vtkLabeledDataMapper mapper)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelMapper_49(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x060019C4 RID: 6596
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area labeling priority.
		/// Default is "GraphVertexDegree".
		/// </summary>
		// Token: 0x060019C5 RID: 6597 RVA: 0x00029843 File Offset: 0x00027A43
		public virtual void SetAreaLabelPriorityArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelPriorityArrayName_50(base.GetCppThis(), name);
		}

		// Token: 0x060019C6 RID: 6598
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_51(HandleRef pThis, HandleRef tp);

		/// <summary>
		/// The text property for the area labels.
		/// </summary>
		// Token: 0x060019C7 RID: 6599 RVA: 0x00029854 File Offset: 0x00027A54
		public virtual void SetAreaLabelTextProperty(vtkTextProperty tp)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelTextProperty_51(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis());
		}

		// Token: 0x060019C8 RID: 6600
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_52(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x060019C9 RID: 6601 RVA: 0x00029883 File Offset: 0x00027A83
		public virtual void SetAreaLabelVisibility(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLabelVisibility_52(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060019CA RID: 6602
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_53(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The layout strategy for producing spatial regions for the tree.
		/// </summary>
		// Token: 0x060019CB RID: 6603 RVA: 0x0002989C File Offset: 0x00027A9C
		public virtual void SetAreaLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaLayoutStrategy_53(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x060019CC RID: 6604
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area sizes. Default is "size".
		/// </summary>
		// Token: 0x060019CD RID: 6605 RVA: 0x000298CB File Offset: 0x00027ACB
		public virtual void SetAreaSizeArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaSizeArrayName_54(base.GetCppThis(), name);
		}

		// Token: 0x060019CE RID: 6606
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_55(HandleRef pThis, HandleRef areaToPoly);

		/// <summary>
		/// The filter for converting areas to polydata. This may e.g. be
		/// vtkTreeMapToPolyData or vtkTreeRingToPolyData.
		/// The filter must take a vtkTree as input and produce vtkPolyData.
		/// </summary>
		// Token: 0x060019CF RID: 6607 RVA: 0x000298DC File Offset: 0x00027ADC
		public virtual void SetAreaToPolyData(vtkPolyDataAlgorithm areaToPoly)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetAreaToPolyData_55(base.GetCppThis(), (areaToPoly == null) ? default(HandleRef) : areaToPoly.GetCppThis());
		}

		// Token: 0x060019D0 RID: 6608
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_56(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060019D1 RID: 6609 RVA: 0x0002990B File Offset: 0x00027B0B
		public virtual void SetColorAreasByArray(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorAreasByArray_56(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060019D2 RID: 6610
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_57(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060019D3 RID: 6611 RVA: 0x00029923 File Offset: 0x00027B23
		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_57(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060019D4 RID: 6612
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_58(HandleRef pThis, byte vis, int idx);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060019D5 RID: 6613 RVA: 0x0002993B File Offset: 0x00027B3B
		public virtual void SetColorGraphEdgesByArray(bool vis, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetColorGraphEdgesByArray_58(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		// Token: 0x060019D6 RID: 6614
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_59(HandleRef pThis, byte b);

		/// <summary>
		/// Visibility of scalar bar actor for edges.
		/// </summary>
		// Token: 0x060019D7 RID: 6615 RVA: 0x00029954 File Offset: 0x00027B54
		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetEdgeScalarBarVisibility_59(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060019D8 RID: 6616
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_60(HandleRef pThis, double strength);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x060019D9 RID: 6617 RVA: 0x0002996C File Offset: 0x00027B6C
		public virtual void SetGraphBundlingStrength(double strength)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_60(base.GetCppThis(), strength);
		}

		// Token: 0x060019DA RID: 6618
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_61(HandleRef pThis, double strength, int idx);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x060019DB RID: 6619 RVA: 0x0002997C File Offset: 0x00027B7C
		public virtual void SetGraphBundlingStrength(double strength, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphBundlingStrength_61(base.GetCppThis(), strength, idx);
		}

		// Token: 0x060019DC RID: 6620
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_62(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x060019DD RID: 6621 RVA: 0x0002998D File Offset: 0x00027B8D
		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_62(base.GetCppThis(), name);
		}

		// Token: 0x060019DE RID: 6622
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int idx);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x060019DF RID: 6623 RVA: 0x0002999D File Offset: 0x00027B9D
		public virtual void SetGraphEdgeColorArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorArrayName_63(base.GetCppThis(), name, idx);
		}

		// Token: 0x060019E0 RID: 6624
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_64(HandleRef pThis);

		/// <summary>
		/// Set the color to be the spline fraction
		/// </summary>
		// Token: 0x060019E1 RID: 6625 RVA: 0x000299AE File Offset: 0x00027BAE
		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_64(base.GetCppThis());
		}

		// Token: 0x060019E2 RID: 6626
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_65(HandleRef pThis, int idx);

		/// <summary>
		/// Set the color to be the spline fraction
		/// </summary>
		// Token: 0x060019E3 RID: 6627 RVA: 0x000299BD File Offset: 0x00027BBD
		public virtual void SetGraphEdgeColorToSplineFraction(int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeColorToSplineFraction_65(base.GetCppThis(), idx);
		}

		// Token: 0x060019E4 RID: 6628
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x060019E5 RID: 6629 RVA: 0x000299CD File Offset: 0x00027BCD
		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_66(base.GetCppThis(), name);
		}

		// Token: 0x060019E6 RID: 6630
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int idx);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x060019E7 RID: 6631 RVA: 0x000299DD File Offset: 0x00027BDD
		public virtual void SetGraphEdgeLabelArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelArrayName_67(base.GetCppThis(), name, idx);
		}

		// Token: 0x060019E8 RID: 6632
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_68(HandleRef pThis, HandleRef tp);

		/// <summary>
		/// The text property for the graph edge labels.
		/// </summary>
		// Token: 0x060019E9 RID: 6633 RVA: 0x000299F0 File Offset: 0x00027BF0
		public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_68(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis());
		}

		// Token: 0x060019EA RID: 6634
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_69(HandleRef pThis, HandleRef tp, int idx);

		/// <summary>
		/// The text property for the graph edge labels.
		/// </summary>
		// Token: 0x060019EB RID: 6635 RVA: 0x00029A20 File Offset: 0x00027C20
		public virtual void SetGraphEdgeLabelTextProperty(vtkTextProperty tp, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelTextProperty_69(base.GetCppThis(), (tp == null) ? default(HandleRef) : tp.GetCppThis(), idx);
		}

		// Token: 0x060019EC RID: 6636
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_70(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060019ED RID: 6637 RVA: 0x00029A50 File Offset: 0x00027C50
		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_70(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060019EE RID: 6638
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_71(HandleRef pThis, byte vis, int idx);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060019EF RID: 6639 RVA: 0x00029A68 File Offset: 0x00027C68
		public virtual void SetGraphEdgeLabelVisibility(bool vis, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphEdgeLabelVisibility_71(base.GetCppThis(), vis ? (byte)1 : (byte)0, idx);
		}

		// Token: 0x060019F0 RID: 6640
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a graph edge.
		/// </summary>
		// Token: 0x060019F1 RID: 6641 RVA: 0x00029A81 File Offset: 0x00027C81
		public virtual void SetGraphHoverArrayName(string name)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_72(base.GetCppThis(), name);
		}

		// Token: 0x060019F2 RID: 6642
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int idx);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a graph edge.
		/// </summary>
		// Token: 0x060019F3 RID: 6643 RVA: 0x00029A91 File Offset: 0x00027C91
		public virtual void SetGraphHoverArrayName(string name, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphHoverArrayName_73(base.GetCppThis(), name, idx);
		}

		// Token: 0x060019F4 RID: 6644
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetGraphSplineType_74(HandleRef pThis, int type, int idx);

		/// <summary>
		/// Sets the spline type for the graph edges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x060019F5 RID: 6645 RVA: 0x00029AA2 File Offset: 0x00027CA2
		public virtual void SetGraphSplineType(int type, int idx)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetGraphSplineType_74(base.GetCppThis(), type, idx);
		}

		// Token: 0x060019F6 RID: 6646
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_75(HandleRef pThis, int mode);

		/// <summary>
		/// Set the label render mode.
		/// QT - Use vtkQtTreeRingLabeler with fitted labeling
		/// and unicode support. Requires VTK_USE_QT to be on.
		/// FREETYPE - Use standard freetype text rendering.
		/// </summary>
		// Token: 0x060019F7 RID: 6647 RVA: 0x00029AB3 File Offset: 0x00027CB3
		public override void SetLabelRenderMode(int mode)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetLabelRenderMode_75(base.GetCppThis(), mode);
		}

		// Token: 0x060019F8 RID: 6648
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_76(HandleRef pThis, double value);

		/// <summary>
		/// Set the region shrink percentage between 0.0 and 1.0.
		/// </summary>
		// Token: 0x060019F9 RID: 6649 RVA: 0x00029AC3 File Offset: 0x00027CC3
		public virtual void SetShrinkPercentage(double value)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetShrinkPercentage_76(base.GetCppThis(), value);
		}

		// Token: 0x060019FA RID: 6650
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_77(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060019FB RID: 6651 RVA: 0x00029AD3 File Offset: 0x00027CD3
		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_SetUseRectangularCoordinates_77(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060019FC RID: 6652
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_78(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060019FD RID: 6653 RVA: 0x00029AEB File Offset: 0x00027CEB
		public virtual void UseRectangularCoordinatesOff()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOff_78(base.GetCppThis());
		}

		// Token: 0x060019FE RID: 6654
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_79(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060019FF RID: 6655 RVA: 0x00029AFA File Offset: 0x00027CFA
		public virtual void UseRectangularCoordinatesOn()
		{
			vtkRenderedTreeAreaRepresentation.vtkRenderedTreeAreaRepresentation_UseRectangularCoordinatesOn_79(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A6 RID: 1190
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedTreeAreaRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A7 RID: 1191
		public new static readonly string MRClassNameKey = "class vtkRenderedTreeAreaRepresentation";
	}
}
