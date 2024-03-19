using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedGraphRepresentation
	///
	///
	/// </summary>
	// Token: 0x02000081 RID: 129
	public class vtkRenderedGraphRepresentation : vtkRenderedRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060017AE RID: 6062 RVA: 0x00027159 File Offset: 0x00025359
		static vtkRenderedGraphRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedGraphRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedGraphRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060017AF RID: 6063 RVA: 0x00027181 File Offset: 0x00025381
		public vtkRenderedGraphRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060017B0 RID: 6064
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017B1 RID: 6065 RVA: 0x00027190 File Offset: 0x00025390
		public new static vtkRenderedGraphRepresentation New()
		{
			vtkRenderedGraphRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060017B2 RID: 6066 RVA: 0x000271E4 File Offset: 0x000253E4
		public vtkRenderedGraphRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060017B3 RID: 6067 RVA: 0x00027228 File Offset: 0x00025428
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060017B4 RID: 6068
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_AddEdgeIconType_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int type);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017B5 RID: 6069 RVA: 0x00027233 File Offset: 0x00025433
		public virtual void AddEdgeIconType(string name, int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_AddEdgeIconType_01(base.GetCppThis(), name, type);
		}

		// Token: 0x060017B6 RID: 6070
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_AddVertexIconType_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int type);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017B7 RID: 6071 RVA: 0x00027244 File Offset: 0x00025444
		public virtual void AddVertexIconType(string name, int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_AddVertexIconType_02(base.GetCppThis(), name, type);
		}

		// Token: 0x060017B8 RID: 6072
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Apply a theme to this representation.
		/// </summary>
		// Token: 0x060017B9 RID: 6073 RVA: 0x00027258 File Offset: 0x00025458
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ApplyViewTheme_03(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x060017BA RID: 6074
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017BB RID: 6075 RVA: 0x00027287 File Offset: 0x00025487
		public virtual void ClearEdgeIconTypes()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ClearEdgeIconTypes_04(base.GetCppThis());
		}

		// Token: 0x060017BC RID: 6076
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017BD RID: 6077 RVA: 0x00027296 File Offset: 0x00025496
		public virtual void ClearVertexIconTypes()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ClearVertexIconTypes_05(base.GetCppThis());
		}

		// Token: 0x060017BE RID: 6078
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017BF RID: 6079 RVA: 0x000272A5 File Offset: 0x000254A5
		public virtual void ColorEdgesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorEdgesByArrayOff_06(base.GetCppThis());
		}

		// Token: 0x060017C0 RID: 6080
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017C1 RID: 6081 RVA: 0x000272B4 File Offset: 0x000254B4
		public virtual void ColorEdgesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorEdgesByArrayOn_07(base.GetCppThis());
		}

		// Token: 0x060017C2 RID: 6082
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017C3 RID: 6083 RVA: 0x000272C3 File Offset: 0x000254C3
		public virtual void ColorVerticesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorVerticesByArrayOff_08(base.GetCppThis());
		}

		// Token: 0x060017C4 RID: 6084
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017C5 RID: 6085 RVA: 0x000272D2 File Offset: 0x000254D2
		public virtual void ColorVerticesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ColorVerticesByArrayOn_09(base.GetCppThis());
		}

		// Token: 0x060017C6 RID: 6086
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Compute the bounding box of the selected subgraph.
		/// </summary>
		// Token: 0x060017C7 RID: 6087 RVA: 0x000272E1 File Offset: 0x000254E1
		public void ComputeSelectedGraphBounds(IntPtr bounds)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ComputeSelectedGraphBounds_10(base.GetCppThis(), bounds);
		}

		// Token: 0x060017C8 RID: 6088
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017C9 RID: 6089 RVA: 0x000272F1 File Offset: 0x000254F1
		public virtual void EdgeIconVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeIconVisibilityOff_11(base.GetCppThis());
		}

		// Token: 0x060017CA RID: 6090
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017CB RID: 6091 RVA: 0x00027300 File Offset: 0x00025500
		public virtual void EdgeIconVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeIconVisibilityOn_12(base.GetCppThis());
		}

		// Token: 0x060017CC RID: 6092
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017CD RID: 6093 RVA: 0x0002730F File Offset: 0x0002550F
		public virtual void EdgeLabelVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeLabelVisibilityOff_13(base.GetCppThis());
		}

		// Token: 0x060017CE RID: 6094
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017CF RID: 6095 RVA: 0x0002731E File Offset: 0x0002551E
		public virtual void EdgeLabelVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeLabelVisibilityOn_14(base.GetCppThis());
		}

		// Token: 0x060017D0 RID: 6096
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017D1 RID: 6097 RVA: 0x0002732D File Offset: 0x0002552D
		public virtual void EdgeVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeVisibilityOff_15(base.GetCppThis());
		}

		// Token: 0x060017D2 RID: 6098
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017D3 RID: 6099 RVA: 0x0002733C File Offset: 0x0002553C
		public virtual void EdgeVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EdgeVisibilityOn_16(base.GetCppThis());
		}

		// Token: 0x060017D4 RID: 6100
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017D5 RID: 6101 RVA: 0x0002734B File Offset: 0x0002554B
		public virtual void EnableEdgesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableEdgesByArrayOff_17(base.GetCppThis());
		}

		// Token: 0x060017D6 RID: 6102
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017D7 RID: 6103 RVA: 0x0002735A File Offset: 0x0002555A
		public virtual void EnableEdgesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableEdgesByArrayOn_18(base.GetCppThis());
		}

		// Token: 0x060017D8 RID: 6104
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017D9 RID: 6105 RVA: 0x00027369 File Offset: 0x00025569
		public virtual void EnableVerticesByArrayOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableVerticesByArrayOff_19(base.GetCppThis());
		}

		// Token: 0x060017DA RID: 6106
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017DB RID: 6107 RVA: 0x00027378 File Offset: 0x00025578
		public virtual void EnableVerticesByArrayOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_EnableVerticesByArrayOn_20(base.GetCppThis());
		}

		// Token: 0x060017DC RID: 6108
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017DD RID: 6109 RVA: 0x00027388 File Offset: 0x00025588
		public virtual bool GetColorEdgesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetColorEdgesByArray_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060017DE RID: 6110
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017DF RID: 6111 RVA: 0x000273B0 File Offset: 0x000255B0
		public virtual bool GetColorVerticesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetColorVerticesByArray_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060017E0 RID: 6112
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017E1 RID: 6113 RVA: 0x000273D8 File Offset: 0x000255D8
		public virtual string GetEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeColorArrayName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017E2 RID: 6114
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017E3 RID: 6115 RVA: 0x00027414 File Offset: 0x00025614
		public virtual string GetEdgeHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeHoverArrayName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017E4 RID: 6116
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017E5 RID: 6117 RVA: 0x00027450 File Offset: 0x00025650
		public virtual int GetEdgeIconAlignment()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconAlignment_25(base.GetCppThis());
		}

		// Token: 0x060017E6 RID: 6118
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017E7 RID: 6119 RVA: 0x00027470 File Offset: 0x00025670
		public virtual string GetEdgeIconArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconArrayName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017E8 RID: 6120
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017E9 RID: 6121 RVA: 0x000274AC File Offset: 0x000256AC
		public virtual string GetEdgeIconPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconPriorityArrayName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017EA RID: 6122
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017EB RID: 6123 RVA: 0x000274E8 File Offset: 0x000256E8
		public virtual bool GetEdgeIconVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeIconVisibility_28(base.GetCppThis()) != 0;
		}

		// Token: 0x060017EC RID: 6124
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017ED RID: 6125 RVA: 0x00027510 File Offset: 0x00025710
		public virtual string GetEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelArrayName_29(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017EE RID: 6126
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017EF RID: 6127 RVA: 0x0002754C File Offset: 0x0002574C
		public virtual string GetEdgeLabelPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelPriorityArrayName_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017F0 RID: 6128
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017F1 RID: 6129 RVA: 0x00027588 File Offset: 0x00025788
		public virtual vtkTextProperty GetEdgeLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelTextProperty_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060017F2 RID: 6130
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060017F3 RID: 6131 RVA: 0x000275F8 File Offset: 0x000257F8
		public virtual bool GetEdgeLabelVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLabelVisibility_32(base.GetCppThis()) != 0;
		}

		// Token: 0x060017F4 RID: 6132
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x060017F5 RID: 6133 RVA: 0x00027620 File Offset: 0x00025820
		public virtual vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLayoutStrategy_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		// Token: 0x060017F6 RID: 6134
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(HandleRef pThis);

		/// <summary>
		/// Set the edge layout strategy by name.
		/// </summary>
		// Token: 0x060017F7 RID: 6135 RVA: 0x00027690 File Offset: 0x00025890
		public virtual string GetEdgeLayoutStrategyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeLayoutStrategyName_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060017F8 RID: 6136
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEdgeScalarBar_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Obtain the scalar bar widget used to draw a legend for the vertices/edges.
		/// </summary>
		// Token: 0x060017F9 RID: 6137 RVA: 0x000276CC File Offset: 0x000258CC
		public virtual vtkScalarBarWidget GetEdgeScalarBar()
		{
			vtkScalarBarWidget vtkScalarBarWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeScalarBar_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarWidget = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarWidget.Register(null);
				}
			}
			return vtkScalarBarWidget;
		}

		// Token: 0x060017FA RID: 6138
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_36(HandleRef pThis);

		/// <summary>
		/// Vertex/edge scalar bar visibility.
		/// </summary>
		// Token: 0x060017FB RID: 6139 RVA: 0x0002773C File Offset: 0x0002593C
		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeScalarBarVisibility_36(base.GetCppThis()) != 0;
		}

		// Token: 0x060017FC RID: 6140
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeSelection_37(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017FD RID: 6141 RVA: 0x00027764 File Offset: 0x00025964
		public bool GetEdgeSelection()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeSelection_37(base.GetCppThis()) != 0;
		}

		// Token: 0x060017FE RID: 6142
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEdgeVisibility_38(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060017FF RID: 6143 RVA: 0x0002778C File Offset: 0x0002598C
		public virtual bool GetEdgeVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEdgeVisibility_38(base.GetCppThis()) != 0;
		}

		// Token: 0x06001800 RID: 6144
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEnableEdgesByArray_39(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001801 RID: 6145 RVA: 0x000277B4 File Offset: 0x000259B4
		public virtual bool GetEnableEdgesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnableEdgesByArray_39(base.GetCppThis()) != 0;
		}

		// Token: 0x06001802 RID: 6146
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetEnableVerticesByArray_40(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001803 RID: 6147 RVA: 0x000277DC File Offset: 0x000259DC
		public virtual bool GetEnableVerticesByArray()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnableVerticesByArray_40(base.GetCppThis()) != 0;
		}

		// Token: 0x06001804 RID: 6148
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_41(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001805 RID: 6149 RVA: 0x00027804 File Offset: 0x00025A04
		public virtual string GetEnabledEdgesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnabledEdgesArrayName_41(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001806 RID: 6150
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_42(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001807 RID: 6151 RVA: 0x00027840 File Offset: 0x00025A40
		public virtual string GetEnabledVerticesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetEnabledVerticesArrayName_42(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001808 RID: 6152
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetGlyphType_43(HandleRef pThis);

		/// <summary>
		/// Set the graph vertex glyph type.
		/// </summary>
		// Token: 0x06001809 RID: 6153 RVA: 0x0002787C File Offset: 0x00025A7C
		public virtual int GetGlyphType()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetGlyphType_43(base.GetCppThis());
		}

		// Token: 0x0600180A RID: 6154
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_44(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600180B RID: 6155 RVA: 0x0002789C File Offset: 0x00025A9C
		public virtual bool GetHideEdgeLabelsOnInteraction()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetHideEdgeLabelsOnInteraction_44(base.GetCppThis()) != 0;
		}

		// Token: 0x0600180C RID: 6156
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_45(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600180D RID: 6157 RVA: 0x000278C4 File Offset: 0x00025AC4
		public virtual bool GetHideVertexLabelsOnInteraction()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetHideVertexLabelsOnInteraction_45(base.GetCppThis()) != 0;
		}

		// Token: 0x0600180E RID: 6158
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategy_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x0600180F RID: 6159 RVA: 0x000278EC File Offset: 0x00025AEC
		public virtual vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetLayoutStrategy_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		// Token: 0x06001810 RID: 6160
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetLayoutStrategyName_47(HandleRef pThis);

		/// <summary>
		/// Get/set the layout strategy by name.
		/// </summary>
		// Token: 0x06001811 RID: 6161 RVA: 0x0002795C File Offset: 0x00025B5C
		public virtual string GetLayoutStrategyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetLayoutStrategyName_47(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001812 RID: 6162
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBase_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001813 RID: 6163 RVA: 0x00027998 File Offset: 0x00025B98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBase_48(base.GetCppThis(), type);
		}

		// Token: 0x06001814 RID: 6164
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBaseType_49([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001815 RID: 6165 RVA: 0x000279B8 File Offset: 0x00025BB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetNumberOfGenerationsFromBaseType_49(type);
		}

		// Token: 0x06001816 RID: 6166
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetScaling_50(HandleRef pThis);

		/// <summary>
		/// Set whether to scale vertex glyphs.
		/// </summary>
		// Token: 0x06001817 RID: 6167 RVA: 0x000279D4 File Offset: 0x00025BD4
		public virtual bool GetScaling()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetScaling_50(base.GetCppThis()) != 0;
		}

		// Token: 0x06001818 RID: 6168
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetScalingArrayName_51(HandleRef pThis);

		/// <summary>
		/// Set the glyph scaling array name.
		/// </summary>
		// Token: 0x06001819 RID: 6169 RVA: 0x000279FC File Offset: 0x00025BFC
		public virtual string GetScalingArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetScalingArrayName_51(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600181A RID: 6170
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_52(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600181B RID: 6171 RVA: 0x00027A38 File Offset: 0x00025C38
		public virtual bool GetUseEdgeIconTypeMap()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetUseEdgeIconTypeMap_52(base.GetCppThis()) != 0;
		}

		// Token: 0x0600181C RID: 6172
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_53(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600181D RID: 6173 RVA: 0x00027A60 File Offset: 0x00025C60
		public virtual bool GetUseVertexIconTypeMap()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetUseVertexIconTypeMap_53(base.GetCppThis()) != 0;
		}

		// Token: 0x0600181E RID: 6174
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexColorArrayName_54(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600181F RID: 6175 RVA: 0x00027A88 File Offset: 0x00025C88
		public virtual string GetVertexColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexColorArrayName_54(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001820 RID: 6176
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexDefaultIcon_55(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001821 RID: 6177 RVA: 0x00027AC4 File Offset: 0x00025CC4
		public virtual int GetVertexDefaultIcon()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexDefaultIcon_55(base.GetCppThis());
		}

		// Token: 0x06001822 RID: 6178
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexHoverArrayName_56(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001823 RID: 6179 RVA: 0x00027AE4 File Offset: 0x00025CE4
		public virtual string GetVertexHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexHoverArrayName_56(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001824 RID: 6180
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexIconAlignment_57(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001825 RID: 6181 RVA: 0x00027B20 File Offset: 0x00025D20
		public virtual int GetVertexIconAlignment()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconAlignment_57(base.GetCppThis());
		}

		// Token: 0x06001826 RID: 6182
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconArrayName_58(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001827 RID: 6183 RVA: 0x00027B40 File Offset: 0x00025D40
		public virtual string GetVertexIconArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconArrayName_58(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001828 RID: 6184
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_59(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001829 RID: 6185 RVA: 0x00027B7C File Offset: 0x00025D7C
		public virtual string GetVertexIconPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconPriorityArrayName_59(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600182A RID: 6186
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_60(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600182B RID: 6187 RVA: 0x00027BB8 File Offset: 0x00025DB8
		public virtual int GetVertexIconSelectionMode()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconSelectionMode_60(base.GetCppThis());
		}

		// Token: 0x0600182C RID: 6188
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexIconVisibility_61(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600182D RID: 6189 RVA: 0x00027BD8 File Offset: 0x00025DD8
		public virtual bool GetVertexIconVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexIconVisibility_61(base.GetCppThis()) != 0;
		}

		// Token: 0x0600182E RID: 6190
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelArrayName_62(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600182F RID: 6191 RVA: 0x00027C00 File Offset: 0x00025E00
		public virtual string GetVertexLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelArrayName_62(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001830 RID: 6192
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_63(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001831 RID: 6193 RVA: 0x00027C3C File Offset: 0x00025E3C
		public virtual string GetVertexLabelPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelPriorityArrayName_63(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001832 RID: 6194
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001833 RID: 6195 RVA: 0x00027C78 File Offset: 0x00025E78
		public virtual vtkTextProperty GetVertexLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelTextProperty_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001834 RID: 6196
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexLabelVisibility_65(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001835 RID: 6197 RVA: 0x00027CE8 File Offset: 0x00025EE8
		public virtual bool GetVertexLabelVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexLabelVisibility_65(base.GetCppThis()) != 0;
		}

		// Token: 0x06001836 RID: 6198
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_GetVertexScalarBar_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Obtain the scalar bar widget used to draw a legend for the vertices/edges.
		/// </summary>
		// Token: 0x06001837 RID: 6199 RVA: 0x00027D10 File Offset: 0x00025F10
		public virtual vtkScalarBarWidget GetVertexScalarBar()
		{
			vtkScalarBarWidget vtkScalarBarWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexScalarBar_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarWidget = (vtkScalarBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarWidget.Register(null);
				}
			}
			return vtkScalarBarWidget;
		}

		// Token: 0x06001838 RID: 6200
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_67(HandleRef pThis);

		/// <summary>
		/// Vertex/edge scalar bar visibility.
		/// </summary>
		// Token: 0x06001839 RID: 6201 RVA: 0x00027D80 File Offset: 0x00025F80
		public virtual bool GetVertexScalarBarVisibility()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexScalarBarVisibility_67(base.GetCppThis()) != 0;
		}

		// Token: 0x0600183A RID: 6202
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_GetVertexSelectedIcon_68(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600183B RID: 6203 RVA: 0x00027DA8 File Offset: 0x00025FA8
		public virtual int GetVertexSelectedIcon()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_GetVertexSelectedIcon_68(base.GetCppThis());
		}

		// Token: 0x0600183C RID: 6204
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_69(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600183D RID: 6205 RVA: 0x00027DC7 File Offset: 0x00025FC7
		public virtual void HideEdgeLabelsOnInteractionOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOff_69(base.GetCppThis());
		}

		// Token: 0x0600183E RID: 6206
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_70(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x0600183F RID: 6207 RVA: 0x00027DD6 File Offset: 0x00025FD6
		public virtual void HideEdgeLabelsOnInteractionOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideEdgeLabelsOnInteractionOn_70(base.GetCppThis());
		}

		// Token: 0x06001840 RID: 6208
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_71(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001841 RID: 6209 RVA: 0x00027DE5 File Offset: 0x00025FE5
		public virtual void HideVertexLabelsOnInteractionOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOff_71(base.GetCppThis());
		}

		// Token: 0x06001842 RID: 6210
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_72(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001843 RID: 6211 RVA: 0x00027DF4 File Offset: 0x00025FF4
		public virtual void HideVertexLabelsOnInteractionOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_HideVertexLabelsOnInteractionOn_72(base.GetCppThis());
		}

		// Token: 0x06001844 RID: 6212
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_IsA_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001845 RID: 6213 RVA: 0x00027E04 File Offset: 0x00026004
		public override int IsA(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsA_73(base.GetCppThis(), type);
		}

		// Token: 0x06001846 RID: 6214
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderedGraphRepresentation_IsLayoutComplete_74(HandleRef pThis);

		/// <summary>
		/// Whether the current graph layout is complete.
		/// </summary>
		// Token: 0x06001847 RID: 6215 RVA: 0x00027E24 File Offset: 0x00026024
		public virtual bool IsLayoutComplete()
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsLayoutComplete_74(base.GetCppThis()) != 0;
		}

		// Token: 0x06001848 RID: 6216
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedGraphRepresentation_IsTypeOf_75([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001849 RID: 6217 RVA: 0x00027E4C File Offset: 0x0002604C
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_IsTypeOf_75(type);
		}

		// Token: 0x0600184A RID: 6218
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600184B RID: 6219 RVA: 0x00027E68 File Offset: 0x00026068
		public new vtkRenderedGraphRepresentation NewInstance()
		{
			vtkRenderedGraphRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_NewInstance_77(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600184C RID: 6220
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedGraphRepresentation_SafeDownCast_78(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600184D RID: 6221 RVA: 0x00027EC4 File Offset: 0x000260C4
		public new static vtkRenderedGraphRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedGraphRepresentation vtkRenderedGraphRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SafeDownCast_78((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedGraphRepresentation = (vtkRenderedGraphRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedGraphRepresentation.Register(null);
				}
			}
			return vtkRenderedGraphRepresentation;
		}

		// Token: 0x0600184E RID: 6222
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ScalingOff_79(HandleRef pThis);

		/// <summary>
		/// Set whether to scale vertex glyphs.
		/// </summary>
		// Token: 0x0600184F RID: 6223 RVA: 0x00027F43 File Offset: 0x00026143
		public virtual void ScalingOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ScalingOff_79(base.GetCppThis());
		}

		// Token: 0x06001850 RID: 6224
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_ScalingOn_80(HandleRef pThis);

		/// <summary>
		/// Set whether to scale vertex glyphs.
		/// </summary>
		// Token: 0x06001851 RID: 6225 RVA: 0x00027F52 File Offset: 0x00026152
		public virtual void ScalingOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_ScalingOn_80(base.GetCppThis());
		}

		// Token: 0x06001852 RID: 6226
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetColorEdgesByArray_81(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001853 RID: 6227 RVA: 0x00027F61 File Offset: 0x00026161
		public virtual void SetColorEdgesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetColorEdgesByArray_81(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001854 RID: 6228
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetColorVerticesByArray_82(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001855 RID: 6229 RVA: 0x00027F79 File Offset: 0x00026179
		public virtual void SetColorVerticesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetColorVerticesByArray_82(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001856 RID: 6230
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeColorArrayName_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001857 RID: 6231 RVA: 0x00027F91 File Offset: 0x00026191
		public virtual void SetEdgeColorArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeColorArrayName_83(base.GetCppThis(), name);
		}

		// Token: 0x06001858 RID: 6232
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001859 RID: 6233 RVA: 0x00027FA1 File Offset: 0x000261A1
		public virtual void SetEdgeHoverArrayName(string _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeHoverArrayName_84(base.GetCppThis(), _arg);
		}

		// Token: 0x0600185A RID: 6234
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconAlignment_85(HandleRef pThis, int align);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600185B RID: 6235 RVA: 0x00027FB1 File Offset: 0x000261B1
		public virtual void SetEdgeIconAlignment(int align)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconAlignment_85(base.GetCppThis(), align);
		}

		// Token: 0x0600185C RID: 6236
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconArrayName_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600185D RID: 6237 RVA: 0x00027FC1 File Offset: 0x000261C1
		public virtual void SetEdgeIconArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconArrayName_86(base.GetCppThis(), name);
		}

		// Token: 0x0600185E RID: 6238
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_87(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600185F RID: 6239 RVA: 0x00027FD1 File Offset: 0x000261D1
		public virtual void SetEdgeIconPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconPriorityArrayName_87(base.GetCppThis(), name);
		}

		// Token: 0x06001860 RID: 6240
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeIconVisibility_88(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001861 RID: 6241 RVA: 0x00027FE1 File Offset: 0x000261E1
		public virtual void SetEdgeIconVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeIconVisibility_88(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001862 RID: 6242
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_89(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001863 RID: 6243 RVA: 0x00027FF9 File Offset: 0x000261F9
		public virtual void SetEdgeLabelArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelArrayName_89(base.GetCppThis(), name);
		}

		// Token: 0x06001864 RID: 6244
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_90(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001865 RID: 6245 RVA: 0x00028009 File Offset: 0x00026209
		public virtual void SetEdgeLabelPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelPriorityArrayName_90(base.GetCppThis(), name);
		}

		// Token: 0x06001866 RID: 6246
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_91(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001867 RID: 6247 RVA: 0x0002801C File Offset: 0x0002621C
		public virtual void SetEdgeLabelTextProperty(vtkTextProperty p)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelTextProperty_91(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06001868 RID: 6248
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_92(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001869 RID: 6249 RVA: 0x0002804B File Offset: 0x0002624B
		public virtual void SetEdgeLabelVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLabelVisibility_92(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600186A RID: 6250
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_93(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x0600186B RID: 6251 RVA: 0x00028064 File Offset: 0x00026264
		public virtual void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy strategy)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_93(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x0600186C RID: 6252
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_94(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the edge layout strategy by name.
		/// </summary>
		// Token: 0x0600186D RID: 6253 RVA: 0x00028093 File Offset: 0x00026293
		public virtual void SetEdgeLayoutStrategy(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategy_94(base.GetCppThis(), name);
		}

		// Token: 0x0600186E RID: 6254
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_95(HandleRef pThis);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x0600186F RID: 6255 RVA: 0x000280A3 File Offset: 0x000262A3
		public void SetEdgeLayoutStrategyToArcParallel()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToArcParallel_95(base.GetCppThis());
		}

		// Token: 0x06001870 RID: 6256
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_96(HandleRef pThis, double explodeFactor);

		/// <summary>
		/// Set the edge layout strategy to a geospatial arced strategy
		/// appropriate for vtkGeoView.
		/// </summary>
		// Token: 0x06001871 RID: 6257 RVA: 0x000280B2 File Offset: 0x000262B2
		public virtual void SetEdgeLayoutStrategyToGeo(double explodeFactor)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToGeo_96(base.GetCppThis(), explodeFactor);
		}

		// Token: 0x06001872 RID: 6258
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_97(HandleRef pThis);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x06001873 RID: 6259 RVA: 0x000280C2 File Offset: 0x000262C2
		public void SetEdgeLayoutStrategyToPassThrough()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeLayoutStrategyToPassThrough_97(base.GetCppThis());
		}

		// Token: 0x06001874 RID: 6260
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_98(HandleRef pThis, byte b);

		/// <summary>
		/// Vertex/edge scalar bar visibility.
		/// </summary>
		// Token: 0x06001875 RID: 6261 RVA: 0x000280D1 File Offset: 0x000262D1
		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeScalarBarVisibility_98(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001876 RID: 6262
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeSelection_99(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001877 RID: 6263 RVA: 0x000280E9 File Offset: 0x000262E9
		public void SetEdgeSelection(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeSelection_99(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001878 RID: 6264
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEdgeVisibility_100(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001879 RID: 6265 RVA: 0x00028101 File Offset: 0x00026301
		public virtual void SetEdgeVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEdgeVisibility_100(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600187A RID: 6266
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEnableEdgesByArray_101(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600187B RID: 6267 RVA: 0x00028119 File Offset: 0x00026319
		public virtual void SetEnableEdgesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnableEdgesByArray_101(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600187C RID: 6268
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEnableVerticesByArray_102(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600187D RID: 6269 RVA: 0x00028131 File Offset: 0x00026331
		public virtual void SetEnableVerticesByArray(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnableVerticesByArray_102(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600187E RID: 6270
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x0600187F RID: 6271 RVA: 0x00028149 File Offset: 0x00026349
		public virtual void SetEnabledEdgesArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnabledEdgesArrayName_103(base.GetCppThis(), name);
		}

		// Token: 0x06001880 RID: 6272
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_104(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x06001881 RID: 6273 RVA: 0x00028159 File Offset: 0x00026359
		public virtual void SetEnabledVerticesArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetEnabledVerticesArrayName_104(base.GetCppThis(), name);
		}

		// Token: 0x06001882 RID: 6274
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetGlyphType_105(HandleRef pThis, int type);

		/// <summary>
		/// Set the graph vertex glyph type.
		/// </summary>
		// Token: 0x06001883 RID: 6275 RVA: 0x00028169 File Offset: 0x00026369
		public virtual void SetGlyphType(int type)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetGlyphType_105(base.GetCppThis(), type);
		}

		// Token: 0x06001884 RID: 6276
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_106(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001885 RID: 6277 RVA: 0x00028179 File Offset: 0x00026379
		public virtual void SetHideEdgeLabelsOnInteraction(bool _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetHideEdgeLabelsOnInteraction_106(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001886 RID: 6278
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_107(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to hide the display of vertex labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x06001887 RID: 6279 RVA: 0x00028191 File Offset: 0x00026391
		public virtual void SetHideVertexLabelsOnInteraction(bool _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetHideVertexLabelsOnInteraction_107(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001888 RID: 6280
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_108(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// Set/get the graph layout strategy.
		/// </summary>
		// Token: 0x06001889 RID: 6281 RVA: 0x000281AC File Offset: 0x000263AC
		public virtual void SetLayoutStrategy(vtkGraphLayoutStrategy strategy)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategy_108(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x0600188A RID: 6282
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategy_109(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/set the layout strategy by name.
		/// </summary>
		// Token: 0x0600188B RID: 6283 RVA: 0x000281DB File Offset: 0x000263DB
		public virtual void SetLayoutStrategy(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategy_109(base.GetCppThis(), name);
		}

		// Token: 0x0600188C RID: 6284
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_110(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string xarr, [MarshalAs(UnmanagedType.LPUTF8Str)] string yarr, [MarshalAs(UnmanagedType.LPUTF8Str)] string zarr);

		/// <summary>
		/// Set the layout strategy to use coordinates from arrays.
		/// The x array must be specified. The y and z arrays are optional.
		/// </summary>
		// Token: 0x0600188D RID: 6285 RVA: 0x000281EB File Offset: 0x000263EB
		public virtual void SetLayoutStrategyToAssignCoordinates(string xarr, string yarr, string zarr)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToAssignCoordinates_110(base.GetCppThis(), xarr, yarr, zarr);
		}

		// Token: 0x0600188E RID: 6286
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_111(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x0600188F RID: 6287 RVA: 0x000281FD File Offset: 0x000263FD
		public void SetLayoutStrategyToCircular()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCircular_111(base.GetCppThis());
		}

		// Token: 0x06001890 RID: 6288
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_112(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x06001891 RID: 6289 RVA: 0x0002820C File Offset: 0x0002640C
		public void SetLayoutStrategyToClustering2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToClustering2D_112(base.GetCppThis());
		}

		// Token: 0x06001892 RID: 6290
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_113(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x06001893 RID: 6291 RVA: 0x0002821B File Offset: 0x0002641B
		public void SetLayoutStrategyToCommunity2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCommunity2D_113(base.GetCppThis());
		}

		// Token: 0x06001894 RID: 6292
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_114(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x06001895 RID: 6293 RVA: 0x0002822A File Offset: 0x0002642A
		public void SetLayoutStrategyToCone()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCone_114(base.GetCppThis());
		}

		// Token: 0x06001896 RID: 6294
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_115(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x06001897 RID: 6295 RVA: 0x00028239 File Offset: 0x00026439
		public void SetLayoutStrategyToCosmicTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_115(base.GetCppThis());
		}

		// Token: 0x06001898 RID: 6296
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_116(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string nodeSizeArrayName, byte sizeLeafNodesOnly, int layoutDepth, long layoutRoot);

		/// <summary>
		/// Set the layout strategy to a cosmic tree layout. nodeSizeArrayName is
		/// the array used to size the circles (default is nullptr, which makes leaf
		/// nodes the same size). sizeLeafNodesOnly only uses the leaf node sizes,
		/// and computes the parent size as the sum of the child sizes (default true).
		/// layoutDepth stops layout at a certain depth (default is 0, which does the
		/// entire tree). layoutRoot is the vertex that will be considered the root
		/// node of the layout (default is -1, which will use the tree's root).
		/// See vtkCosmicTreeLayoutStrategy for more information.
		/// </summary>
		// Token: 0x06001899 RID: 6297 RVA: 0x00028248 File Offset: 0x00026448
		public virtual void SetLayoutStrategyToCosmicTree(string nodeSizeArrayName, bool sizeLeafNodesOnly, int layoutDepth, long layoutRoot)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToCosmicTree_116(base.GetCppThis(), nodeSizeArrayName, sizeLeafNodesOnly ? (byte)1 : (byte)0, layoutDepth, layoutRoot);
		}

		// Token: 0x0600189A RID: 6298
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_117(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x0600189B RID: 6299 RVA: 0x00028264 File Offset: 0x00026464
		public void SetLayoutStrategyToFast2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToFast2D_117(base.GetCppThis());
		}

		// Token: 0x0600189C RID: 6300
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_118(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x0600189D RID: 6301 RVA: 0x00028273 File Offset: 0x00026473
		public void SetLayoutStrategyToForceDirected()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToForceDirected_118(base.GetCppThis());
		}

		// Token: 0x0600189E RID: 6302
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_119(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x0600189F RID: 6303 RVA: 0x00028282 File Offset: 0x00026482
		public void SetLayoutStrategyToPassThrough()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToPassThrough_119(base.GetCppThis());
		}

		// Token: 0x060018A0 RID: 6304
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_120(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x060018A1 RID: 6305 RVA: 0x00028291 File Offset: 0x00026491
		public void SetLayoutStrategyToRandom()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToRandom_120(base.GetCppThis());
		}

		// Token: 0x060018A2 RID: 6306
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_121(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x060018A3 RID: 6307 RVA: 0x000282A0 File Offset: 0x000264A0
		public void SetLayoutStrategyToSimple2D()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToSimple2D_121(base.GetCppThis());
		}

		// Token: 0x060018A4 RID: 6308
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_122(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x060018A5 RID: 6309 RVA: 0x000282AF File Offset: 0x000264AF
		public void SetLayoutStrategyToSpanTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToSpanTree_122(base.GetCppThis());
		}

		// Token: 0x060018A6 RID: 6310
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_123(HandleRef pThis);

		/// <summary>
		/// Set predefined layout strategies.
		/// </summary>
		// Token: 0x060018A7 RID: 6311 RVA: 0x000282BE File Offset: 0x000264BE
		public void SetLayoutStrategyToTree()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_123(base.GetCppThis());
		}

		// Token: 0x060018A8 RID: 6312
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_124(HandleRef pThis, byte radial, double angle, double leafSpacing, double logSpacing);

		/// <summary>
		/// Set the layout strategy to a tree layout. Radial indicates whether to
		/// do a radial or standard top-down tree layout. The angle parameter is the
		/// angular distance spanned by the tree. Leaf spacing is a
		/// value from 0 to 1 indicating how much of the radial layout should be
		/// allocated to leaf nodes (as opposed to between tree branches). The log spacing value is a
		/// non-negative value where &gt; 1 will create expanding levels, &lt; 1 will create
		/// contracting levels, and = 1 makes all levels the same size. See
		/// vtkTreeLayoutStrategy for more information.
		/// </summary>
		// Token: 0x060018A9 RID: 6313 RVA: 0x000282CD File Offset: 0x000264CD
		public virtual void SetLayoutStrategyToTree(bool radial, double angle, double leafSpacing, double logSpacing)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetLayoutStrategyToTree_124(base.GetCppThis(), radial ? (byte)1 : (byte)0, angle, leafSpacing, logSpacing);
		}

		// Token: 0x060018AA RID: 6314
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetScaling_125(HandleRef pThis, byte b);

		/// <summary>
		/// Set whether to scale vertex glyphs.
		/// </summary>
		// Token: 0x060018AB RID: 6315 RVA: 0x000282E9 File Offset: 0x000264E9
		public virtual void SetScaling(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetScaling_125(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018AC RID: 6316
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetScalingArrayName_126(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the glyph scaling array name.
		/// </summary>
		// Token: 0x060018AD RID: 6317 RVA: 0x00028301 File Offset: 0x00026501
		public virtual void SetScalingArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetScalingArrayName_126(base.GetCppThis(), name);
		}

		// Token: 0x060018AE RID: 6318
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_127(HandleRef pThis, byte b);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018AF RID: 6319 RVA: 0x00028311 File Offset: 0x00026511
		public virtual void SetUseEdgeIconTypeMap(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetUseEdgeIconTypeMap_127(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018B0 RID: 6320
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_128(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018B1 RID: 6321 RVA: 0x00028329 File Offset: 0x00026529
		public virtual void SetUseVertexIconTypeMap(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetUseVertexIconTypeMap_128(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018B2 RID: 6322
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexColorArrayName_129(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018B3 RID: 6323 RVA: 0x00028341 File Offset: 0x00026541
		public virtual void SetVertexColorArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexColorArrayName_129(base.GetCppThis(), name);
		}

		// Token: 0x060018B4 RID: 6324
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexDefaultIcon_130(HandleRef pThis, int icon);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018B5 RID: 6325 RVA: 0x00028351 File Offset: 0x00026551
		public virtual void SetVertexDefaultIcon(int icon)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexDefaultIcon_130(base.GetCppThis(), icon);
		}

		// Token: 0x060018B6 RID: 6326
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexHoverArrayName_131(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018B7 RID: 6327 RVA: 0x00028361 File Offset: 0x00026561
		public virtual void SetVertexHoverArrayName(string _arg)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexHoverArrayName_131(base.GetCppThis(), _arg);
		}

		// Token: 0x060018B8 RID: 6328
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconAlignment_132(HandleRef pThis, int align);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018B9 RID: 6329 RVA: 0x00028371 File Offset: 0x00026571
		public virtual void SetVertexIconAlignment(int align)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconAlignment_132(base.GetCppThis(), align);
		}

		// Token: 0x060018BA RID: 6330
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconArrayName_133(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018BB RID: 6331 RVA: 0x00028381 File Offset: 0x00026581
		public virtual void SetVertexIconArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconArrayName_133(base.GetCppThis(), name);
		}

		// Token: 0x060018BC RID: 6332
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_134(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018BD RID: 6333 RVA: 0x00028391 File Offset: 0x00026591
		public virtual void SetVertexIconPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconPriorityArrayName_134(base.GetCppThis(), name);
		}

		// Token: 0x060018BE RID: 6334
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_135(HandleRef pThis, int mode);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018BF RID: 6335 RVA: 0x000283A1 File Offset: 0x000265A1
		public virtual void SetVertexIconSelectionMode(int mode)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionMode_135(base.GetCppThis(), mode);
		}

		// Token: 0x060018C0 RID: 6336
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_136(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018C1 RID: 6337 RVA: 0x000283B1 File Offset: 0x000265B1
		public virtual void SetVertexIconSelectionModeToAnnotationIcon()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToAnnotationIcon_136(base.GetCppThis());
		}

		// Token: 0x060018C2 RID: 6338
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_137(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018C3 RID: 6339 RVA: 0x000283C0 File Offset: 0x000265C0
		public virtual void SetVertexIconSelectionModeToIgnoreSelection()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToIgnoreSelection_137(base.GetCppThis());
		}

		// Token: 0x060018C4 RID: 6340
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_138(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018C5 RID: 6341 RVA: 0x000283CF File Offset: 0x000265CF
		public virtual void SetVertexIconSelectionModeToSelectedIcon()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedIcon_138(base.GetCppThis());
		}

		// Token: 0x060018C6 RID: 6342
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_139(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018C7 RID: 6343 RVA: 0x000283DE File Offset: 0x000265DE
		public virtual void SetVertexIconSelectionModeToSelectedOffset()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconSelectionModeToSelectedOffset_139(base.GetCppThis());
		}

		// Token: 0x060018C8 RID: 6344
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexIconVisibility_140(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018C9 RID: 6345 RVA: 0x000283ED File Offset: 0x000265ED
		public virtual void SetVertexIconVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexIconVisibility_140(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018CA RID: 6346
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelArrayName_141(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018CB RID: 6347 RVA: 0x00028405 File Offset: 0x00026605
		public virtual void SetVertexLabelArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelArrayName_141(base.GetCppThis(), name);
		}

		// Token: 0x060018CC RID: 6348
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_142(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018CD RID: 6349 RVA: 0x00028415 File Offset: 0x00026615
		public virtual void SetVertexLabelPriorityArrayName(string name)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelPriorityArrayName_142(base.GetCppThis(), name);
		}

		// Token: 0x060018CE RID: 6350
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_143(HandleRef pThis, HandleRef p);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018CF RID: 6351 RVA: 0x00028428 File Offset: 0x00026628
		public virtual void SetVertexLabelTextProperty(vtkTextProperty p)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelTextProperty_143(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060018D0 RID: 6352
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexLabelVisibility_144(HandleRef pThis, byte b);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018D1 RID: 6353 RVA: 0x00028457 File Offset: 0x00026657
		public virtual void SetVertexLabelVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexLabelVisibility_144(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018D2 RID: 6354
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_145(HandleRef pThis, byte b);

		/// <summary>
		/// Vertex/edge scalar bar visibility.
		/// </summary>
		// Token: 0x060018D3 RID: 6355 RVA: 0x0002846F File Offset: 0x0002666F
		public virtual void SetVertexScalarBarVisibility(bool b)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexScalarBarVisibility_145(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060018D4 RID: 6356
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_SetVertexSelectedIcon_146(HandleRef pThis, int icon);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018D5 RID: 6357 RVA: 0x00028487 File Offset: 0x00026687
		public virtual void SetVertexSelectedIcon(int icon)
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_SetVertexSelectedIcon_146(base.GetCppThis(), icon);
		}

		// Token: 0x060018D6 RID: 6358
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_UpdateLayout_147(HandleRef pThis);

		/// <summary>
		/// Performs another iteration on the graph layout.
		/// </summary>
		// Token: 0x060018D7 RID: 6359 RVA: 0x00028497 File Offset: 0x00026697
		public virtual void UpdateLayout()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UpdateLayout_147(base.GetCppThis());
		}

		// Token: 0x060018D8 RID: 6360
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_148(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018D9 RID: 6361 RVA: 0x000284A6 File Offset: 0x000266A6
		public virtual void UseEdgeIconTypeMapOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOff_148(base.GetCppThis());
		}

		// Token: 0x060018DA RID: 6362
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_149(HandleRef pThis);

		/// <summary>
		/// Set the mode to one of
		/// &lt;ul&gt;
		/// &lt;li&gt;vtkApplyIcons::SELECTED_ICON - use VertexSelectedIcon
		/// &lt;li&gt;vtkApplyIcons::SELECTED_OFFSET - use VertexSelectedIcon as offset
		/// &lt;li&gt;vtkApplyIcons::ANNOTATION_ICON - use current annotation icon
		/// &lt;li&gt;vtkApplyIcons::IGNORE_SELECTION - ignore selected elements
		/// &lt;/ul&gt;
		/// The default is IGNORE_SELECTION.
		/// </summary>
		// Token: 0x060018DB RID: 6363 RVA: 0x000284B5 File Offset: 0x000266B5
		public virtual void UseEdgeIconTypeMapOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseEdgeIconTypeMapOn_149(base.GetCppThis());
		}

		// Token: 0x060018DC RID: 6364
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_150(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018DD RID: 6365 RVA: 0x000284C4 File Offset: 0x000266C4
		public virtual void UseVertexIconTypeMapOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseVertexIconTypeMapOff_150(base.GetCppThis());
		}

		// Token: 0x060018DE RID: 6366
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_151(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018DF RID: 6367 RVA: 0x000284D3 File Offset: 0x000266D3
		public virtual void UseVertexIconTypeMapOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_UseVertexIconTypeMapOn_151(base.GetCppThis());
		}

		// Token: 0x060018E0 RID: 6368
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOff_152(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018E1 RID: 6369 RVA: 0x000284E2 File Offset: 0x000266E2
		public virtual void VertexIconVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexIconVisibilityOff_152(base.GetCppThis());
		}

		// Token: 0x060018E2 RID: 6370
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_VertexIconVisibilityOn_153(HandleRef pThis);

		/// <summary>
		/// Whether to hide the display of edge labels during mouse interaction.  Default is off.
		/// </summary>
		// Token: 0x060018E3 RID: 6371 RVA: 0x000284F1 File Offset: 0x000266F1
		public virtual void VertexIconVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexIconVisibilityOn_153(base.GetCppThis());
		}

		// Token: 0x060018E4 RID: 6372
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_154(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018E5 RID: 6373 RVA: 0x00028500 File Offset: 0x00026700
		public virtual void VertexLabelVisibilityOff()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexLabelVisibilityOff_154(base.GetCppThis());
		}

		// Token: 0x060018E6 RID: 6374
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_155(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060018E7 RID: 6375 RVA: 0x0002850F File Offset: 0x0002670F
		public virtual void VertexLabelVisibilityOn()
		{
			vtkRenderedGraphRepresentation.vtkRenderedGraphRepresentation_VertexLabelVisibilityOn_155(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A0 RID: 1184
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedGraphRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004A1 RID: 1185
		public new static readonly string MRClassNameKey = "class vtkRenderedGraphRepresentation";
	}
}
