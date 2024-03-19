using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalGraphPipeline
	/// </summary>
	/// <remarks>
	///    helper class for rendering graphs superimposed on a tree.
	///
	///
	/// vtkHierarchicalGraphPipeline renders bundled edges that are meant to be
	/// viewed as an overlay on a tree. This class is not for general use, but
	/// is used in the internals of vtkRenderedHierarchyRepresentation and
	/// vtkRenderedTreeAreaRepresentation.
	/// </remarks>
	// Token: 0x0200006D RID: 109
	public class vtkHierarchicalGraphPipeline : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060013BC RID: 5052 RVA: 0x00021F43 File Offset: 0x00020143
		static vtkHierarchicalGraphPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalGraphPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060013BD RID: 5053 RVA: 0x00021F6B File Offset: 0x0002016B
		public vtkHierarchicalGraphPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060013BE RID: 5054
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013BF RID: 5055 RVA: 0x00021F7C File Offset: 0x0002017C
		public new static vtkHierarchicalGraphPipeline New()
		{
			vtkHierarchicalGraphPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013C0 RID: 5056 RVA: 0x00021FD0 File Offset: 0x000201D0
		public vtkHierarchicalGraphPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060013C1 RID: 5057 RVA: 0x00022014 File Offset: 0x00020214
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060013C2 RID: 5058
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Applies the view theme to this graph.
		/// </summary>
		// Token: 0x060013C3 RID: 5059 RVA: 0x00022020 File Offset: 0x00020220
		public virtual void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x060013C4 RID: 5060
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(HandleRef pThis);

		/// <summary>
		/// Whether to color the edges by an array.
		/// </summary>
		// Token: 0x060013C5 RID: 5061 RVA: 0x0002204F File Offset: 0x0002024F
		public virtual void ColorEdgesByArrayOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ColorEdgesByArrayOff_02(base.GetCppThis());
		}

		// Token: 0x060013C6 RID: 5062
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(HandleRef pThis);

		/// <summary>
		/// Whether to color the edges by an array.
		/// </summary>
		// Token: 0x060013C7 RID: 5063 RVA: 0x0002205E File Offset: 0x0002025E
		public virtual void ColorEdgesByArrayOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ColorEdgesByArrayOn_03(base.GetCppThis());
		}

		// Token: 0x060013C8 RID: 5064
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_ConvertSelection_04(HandleRef pThis, HandleRef rep, HandleRef sel, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a new selection relevant to this graph based on an input
		/// selection and the view that this graph is contained in.
		/// </summary>
		// Token: 0x060013C9 RID: 5065 RVA: 0x00022070 File Offset: 0x00020270
		public virtual vtkSelection ConvertSelection(vtkDataRepresentation rep, vtkSelection sel)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_ConvertSelection_04(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		// Token: 0x060013CA RID: 5066
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetActor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The actor associated with the hierarchical graph.
		/// </summary>
		// Token: 0x060013CB RID: 5067 RVA: 0x0002210C File Offset: 0x0002030C
		public virtual vtkActor GetActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetActor_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x060013CC RID: 5068
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHierarchicalGraphPipeline_GetBundlingStrength_06(HandleRef pThis);

		/// <summary>
		/// The bundling strength for the bundled edges.
		/// </summary>
		// Token: 0x060013CD RID: 5069 RVA: 0x0002217C File Offset: 0x0002037C
		public virtual double GetBundlingStrength()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetBundlingStrength_06(base.GetCppThis());
		}

		// Token: 0x060013CE RID: 5070
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetColorArrayName_07(HandleRef pThis);

		/// <summary>
		/// The edge color array.
		/// </summary>
		// Token: 0x060013CF RID: 5071 RVA: 0x0002219C File Offset: 0x0002039C
		public virtual string GetColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetColorArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060013D0 RID: 5072
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(HandleRef pThis);

		/// <summary>
		/// Whether to color the edges by an array.
		/// </summary>
		// Token: 0x060013D1 RID: 5073 RVA: 0x000221D8 File Offset: 0x000203D8
		public virtual bool GetColorEdgesByArray()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetColorEdgesByArray_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060013D2 RID: 5074
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetHoverArrayName_09(HandleRef pThis);

		/// <summary>
		/// The array to use while hovering over an edge.
		/// </summary>
		// Token: 0x060013D3 RID: 5075 RVA: 0x00022200 File Offset: 0x00020400
		public virtual string GetHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetHoverArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060013D4 RID: 5076
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelActor_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The actor associated with the hierarchical graph.
		/// </summary>
		// Token: 0x060013D5 RID: 5077 RVA: 0x0002223C File Offset: 0x0002043C
		public virtual vtkActor2D GetLabelActor()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelActor_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x060013D6 RID: 5078
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelArrayName_11(HandleRef pThis);

		/// <summary>
		/// The edge label array name.
		/// </summary>
		// Token: 0x060013D7 RID: 5079 RVA: 0x000222AC File Offset: 0x000204AC
		public virtual string GetLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelArrayName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060013D8 RID: 5080
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The edge label text property.
		/// </summary>
		// Token: 0x060013D9 RID: 5081 RVA: 0x000222E8 File Offset: 0x000204E8
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelTextProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060013DA RID: 5082
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphPipeline_GetLabelVisibility_13(HandleRef pThis);

		/// <summary>
		/// The edge label visibility.
		/// </summary>
		// Token: 0x060013DB RID: 5083 RVA: 0x00022358 File Offset: 0x00020558
		public virtual bool GetLabelVisibility()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetLabelVisibility_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060013DC RID: 5084
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013DD RID: 5085 RVA: 0x00022380 File Offset: 0x00020580
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060013DE RID: 5086
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013DF RID: 5087 RVA: 0x000223A0 File Offset: 0x000205A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060013E0 RID: 5088
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphPipeline_GetSplineType_16(HandleRef pThis);

		/// <summary>
		/// The spline mode to use in vtkSplineGraphEdges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x060013E1 RID: 5089 RVA: 0x000223BC File Offset: 0x000205BC
		public virtual int GetSplineType()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetSplineType_16(base.GetCppThis());
		}

		// Token: 0x060013E2 RID: 5090
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphPipeline_GetVisibility_17(HandleRef pThis);

		/// <summary>
		/// The visibility of this graph.
		/// </summary>
		// Token: 0x060013E3 RID: 5091 RVA: 0x000223DC File Offset: 0x000205DC
		public virtual bool GetVisibility()
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_GetVisibility_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060013E4 RID: 5092
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphPipeline_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013E5 RID: 5093 RVA: 0x00022404 File Offset: 0x00020604
		public override int IsA(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060013E6 RID: 5094
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphPipeline_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013E7 RID: 5095 RVA: 0x00022424 File Offset: 0x00020624
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_IsTypeOf_19(type);
		}

		// Token: 0x060013E8 RID: 5096
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOff_20(HandleRef pThis);

		/// <summary>
		/// The edge label visibility.
		/// </summary>
		// Token: 0x060013E9 RID: 5097 RVA: 0x0002243E File Offset: 0x0002063E
		public virtual void LabelVisibilityOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_LabelVisibilityOff_20(base.GetCppThis());
		}

		// Token: 0x060013EA RID: 5098
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_LabelVisibilityOn_21(HandleRef pThis);

		/// <summary>
		/// The edge label visibility.
		/// </summary>
		// Token: 0x060013EB RID: 5099 RVA: 0x0002244D File Offset: 0x0002064D
		public virtual void LabelVisibilityOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_LabelVisibilityOn_21(base.GetCppThis());
		}

		// Token: 0x060013EC RID: 5100
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013ED RID: 5101 RVA: 0x0002245C File Offset: 0x0002065C
		public new vtkHierarchicalGraphPipeline NewInstance()
		{
			vtkHierarchicalGraphPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060013EE RID: 5102
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_PrepareInputConnections_24(HandleRef pThis, HandleRef graphConn, HandleRef treeConn, HandleRef annConn);

		/// <summary>
		/// Sets the input connections for this graph.
		/// graphConn is the input graph connection.
		/// treeConn is the input tree connection.
		/// annConn is the annotation link connection.
		/// </summary>
		// Token: 0x060013EF RID: 5103 RVA: 0x000224B8 File Offset: 0x000206B8
		public virtual void PrepareInputConnections(vtkAlgorithmOutput graphConn, vtkAlgorithmOutput treeConn, vtkAlgorithmOutput annConn)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_PrepareInputConnections_24(base.GetCppThis(), (graphConn == null) ? default(HandleRef) : graphConn.GetCppThis(), (treeConn == null) ? default(HandleRef) : treeConn.GetCppThis(), (annConn == null) ? default(HandleRef) : annConn.GetCppThis());
		}

		// Token: 0x060013F0 RID: 5104
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_RegisterProgress_25(HandleRef pThis, HandleRef view);

		/// <summary>
		/// Register progress with a view.
		/// </summary>
		// Token: 0x060013F1 RID: 5105 RVA: 0x00022514 File Offset: 0x00020714
		public void RegisterProgress(vtkRenderView view)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_RegisterProgress_25(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis());
		}

		// Token: 0x060013F2 RID: 5106
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphPipeline_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060013F3 RID: 5107 RVA: 0x00022544 File Offset: 0x00020744
		public new static vtkHierarchicalGraphPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalGraphPipeline vtkHierarchicalGraphPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalGraphPipeline = (vtkHierarchicalGraphPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalGraphPipeline.Register(null);
				}
			}
			return vtkHierarchicalGraphPipeline;
		}

		// Token: 0x060013F4 RID: 5108
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetBundlingStrength_27(HandleRef pThis, double strength);

		/// <summary>
		/// The bundling strength for the bundled edges.
		/// </summary>
		// Token: 0x060013F5 RID: 5109 RVA: 0x000225C3 File Offset: 0x000207C3
		public virtual void SetBundlingStrength(double strength)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetBundlingStrength_27(base.GetCppThis(), strength);
		}

		// Token: 0x060013F6 RID: 5110
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetColorArrayName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The edge color array.
		/// </summary>
		// Token: 0x060013F7 RID: 5111 RVA: 0x000225D3 File Offset: 0x000207D3
		public virtual void SetColorArrayName(string name)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetColorArrayName_28(base.GetCppThis(), name);
		}

		// Token: 0x060013F8 RID: 5112
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetColorEdgesByArray_29(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color the edges by an array.
		/// </summary>
		// Token: 0x060013F9 RID: 5113 RVA: 0x000225E3 File Offset: 0x000207E3
		public virtual void SetColorEdgesByArray(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetColorEdgesByArray_29(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060013FA RID: 5114
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetHoverArrayName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The array to use while hovering over an edge.
		/// </summary>
		// Token: 0x060013FB RID: 5115 RVA: 0x000225FB File Offset: 0x000207FB
		public virtual void SetHoverArrayName(string _arg)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetHoverArrayName_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060013FC RID: 5116
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelArrayName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The edge label array name.
		/// </summary>
		// Token: 0x060013FD RID: 5117 RVA: 0x0002260B File Offset: 0x0002080B
		public virtual void SetLabelArrayName(string name)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelArrayName_31(base.GetCppThis(), name);
		}

		// Token: 0x060013FE RID: 5118
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelTextProperty_32(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// The edge label text property.
		/// </summary>
		// Token: 0x060013FF RID: 5119 RVA: 0x0002261C File Offset: 0x0002081C
		public virtual void SetLabelTextProperty(vtkTextProperty prop)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelTextProperty_32(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06001400 RID: 5120
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetLabelVisibility_33(HandleRef pThis, byte vis);

		/// <summary>
		/// The edge label visibility.
		/// </summary>
		// Token: 0x06001401 RID: 5121 RVA: 0x0002264B File Offset: 0x0002084B
		public virtual void SetLabelVisibility(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetLabelVisibility_33(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001402 RID: 5122
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetSplineType_34(HandleRef pThis, int type);

		/// <summary>
		/// The spline mode to use in vtkSplineGraphEdges.
		/// vtkSplineGraphEdges::CUSTOM uses a vtkCardinalSpline.
		/// vtkSplineGraphEdges::BSPLINE uses a b-spline.
		/// The default is BSPLINE.
		/// </summary>
		// Token: 0x06001403 RID: 5123 RVA: 0x00022663 File Offset: 0x00020863
		public virtual void SetSplineType(int type)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetSplineType_34(base.GetCppThis(), type);
		}

		// Token: 0x06001404 RID: 5124
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_SetVisibility_35(HandleRef pThis, byte vis);

		/// <summary>
		/// The visibility of this graph.
		/// </summary>
		// Token: 0x06001405 RID: 5125 RVA: 0x00022673 File Offset: 0x00020873
		public virtual void SetVisibility(bool vis)
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_SetVisibility_35(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001406 RID: 5126
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_VisibilityOff_36(HandleRef pThis);

		/// <summary>
		/// The visibility of this graph.
		/// </summary>
		// Token: 0x06001407 RID: 5127 RVA: 0x0002268B File Offset: 0x0002088B
		public virtual void VisibilityOff()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_VisibilityOff_36(base.GetCppThis());
		}

		// Token: 0x06001408 RID: 5128
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphPipeline_VisibilityOn_37(HandleRef pThis);

		/// <summary>
		/// The visibility of this graph.
		/// </summary>
		// Token: 0x06001409 RID: 5129 RVA: 0x0002269A File Offset: 0x0002089A
		public virtual void VisibilityOn()
		{
			vtkHierarchicalGraphPipeline.vtkHierarchicalGraphPipeline_VisibilityOn_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000468 RID: 1128
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000469 RID: 1129
		public new static readonly string MRClassNameKey = "class vtkHierarchicalGraphPipeline";
	}
}
