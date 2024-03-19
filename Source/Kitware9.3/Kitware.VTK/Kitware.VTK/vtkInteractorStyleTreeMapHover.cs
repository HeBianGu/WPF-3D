using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleTreeMapHover
	/// </summary>
	/// <remarks>
	///    An interactor style for a tree map view
	///
	///
	/// The vtkInteractorStyleTreeMapHover specifically works with pipelines
	/// that create a tree map.  Such pipelines will have a vtkTreeMapLayout
	/// filter and a vtkTreeMapToPolyData filter, both of which must be passed
	/// to this interactor style for it to function correctly.
	/// This interactor style allows only 2D panning and zooming, and additionally
	/// provides a balloon containing the name of the vertex hovered over,
	/// and allows the user to highlight a vertex by clicking on it.
	/// </remarks>
	// Token: 0x02000077 RID: 119
	public class vtkInteractorStyleTreeMapHover : vtkInteractorStyleImage
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600161C RID: 5660 RVA: 0x00024E50 File Offset: 0x00023050
		static vtkInteractorStyleTreeMapHover()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleTreeMapHover.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleTreeMapHover"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600161D RID: 5661 RVA: 0x00024E78 File Offset: 0x00023078
		public vtkInteractorStyleTreeMapHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600161E RID: 5662
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600161F RID: 5663 RVA: 0x00024E88 File Offset: 0x00023088
		public new static vtkInteractorStyleTreeMapHover New()
		{
			vtkInteractorStyleTreeMapHover result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001620 RID: 5664 RVA: 0x00024EDC File Offset: 0x000230DC
		public vtkInteractorStyleTreeMapHover() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001621 RID: 5665 RVA: 0x00024F20 File Offset: 0x00023120
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001622 RID: 5666
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(HandleRef pThis);

		/// <summary>
		/// The width of the line around the hovered vertex.
		/// </summary>
		// Token: 0x06001623 RID: 5667 RVA: 0x00024F2C File Offset: 0x0002312C
		public double GetHighLightWidth()
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetHighLightWidth_01(base.GetCppThis());
		}

		// Token: 0x06001624 RID: 5668
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLabelField_02(HandleRef pThis);

		/// <summary>
		/// The name of the field to use when displaying text in the hover balloon.
		/// </summary>
		// Token: 0x06001625 RID: 5669 RVA: 0x00024F4C File Offset: 0x0002314C
		public virtual string GetLabelField()
		{
			string s = Marshal.PtrToStringAnsi(vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetLabelField_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001626 RID: 5670
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetLayout_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Must be set to the vtkTreeMapLayout used to compute the bounds of each vertex
		/// for the tree map.
		/// </summary>
		// Token: 0x06001627 RID: 5671 RVA: 0x00024F88 File Offset: 0x00023188
		public virtual vtkTreeMapLayout GetLayout()
		{
			vtkTreeMapLayout vtkTreeMapLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetLayout_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayout = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayout.Register(null);
				}
			}
			return vtkTreeMapLayout;
		}

		// Token: 0x06001628 RID: 5672
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001629 RID: 5673 RVA: 0x00024FF8 File Offset: 0x000231F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600162A RID: 5674
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600162B RID: 5675 RVA: 0x00025018 File Offset: 0x00023218
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600162C RID: 5676
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleTreeMapHover_GetSelectionWidth_06(HandleRef pThis);

		/// <summary>
		/// The width of the line around the selected vertex.
		/// </summary>
		// Token: 0x0600162D RID: 5677 RVA: 0x00025034 File Offset: 0x00023234
		public double GetSelectionWidth()
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetSelectionWidth_06(base.GetCppThis());
		}

		// Token: 0x0600162E RID: 5678
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Must be set to the vtkTreeMapToPolyData used to convert the tree map
		/// into polydata.
		/// </summary>
		// Token: 0x0600162F RID: 5679 RVA: 0x00025054 File Offset: 0x00023254
		public virtual vtkTreeMapToPolyData GetTreeMapToPolyData()
		{
			vtkTreeMapToPolyData vtkTreeMapToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_GetTreeMapToPolyData_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapToPolyData = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapToPolyData.Register(null);
				}
			}
			return vtkTreeMapToPolyData;
		}

		// Token: 0x06001630 RID: 5680
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_08(HandleRef pThis);

		/// <summary>
		/// Highlights a specific vertex.
		/// </summary>
		// Token: 0x06001631 RID: 5681 RVA: 0x000250C3 File Offset: 0x000232C3
		public void HighLightCurrentSelectedItem()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_HighLightCurrentSelectedItem_08(base.GetCppThis());
		}

		// Token: 0x06001632 RID: 5682
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_HighLightItem_09(HandleRef pThis, long id);

		/// <summary>
		/// Highlights a specific vertex.
		/// </summary>
		// Token: 0x06001633 RID: 5683 RVA: 0x000250D2 File Offset: 0x000232D2
		public void HighLightItem(long id)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_HighLightItem_09(base.GetCppThis(), id);
		}

		// Token: 0x06001634 RID: 5684
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTreeMapHover_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001635 RID: 5685 RVA: 0x000250E4 File Offset: 0x000232E4
		public override int IsA(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06001636 RID: 5686
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleTreeMapHover_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001637 RID: 5687 RVA: 0x00025104 File Offset: 0x00023304
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_IsTypeOf_11(type);
		}

		// Token: 0x06001638 RID: 5688
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001639 RID: 5689 RVA: 0x00025120 File Offset: 0x00023320
		public new vtkInteractorStyleTreeMapHover NewInstance()
		{
			vtkInteractorStyleTreeMapHover result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600163A RID: 5690
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_OnLeftButtonUp_14(HandleRef pThis);

		/// <summary>
		/// Overridden from vtkInteractorStyleImage to provide the desired
		/// interaction behavior.
		/// </summary>
		// Token: 0x0600163B RID: 5691 RVA: 0x0002517A File Offset: 0x0002337A
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_OnLeftButtonUp_14(base.GetCppThis());
		}

		// Token: 0x0600163C RID: 5692
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_OnMouseMove_15(HandleRef pThis);

		/// <summary>
		/// Overridden from vtkInteractorStyleImage to provide the desired
		/// interaction behavior.
		/// </summary>
		// Token: 0x0600163D RID: 5693 RVA: 0x00025189 File Offset: 0x00023389
		public override void OnMouseMove()
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_OnMouseMove_15(base.GetCppThis());
		}

		// Token: 0x0600163E RID: 5694
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleTreeMapHover_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600163F RID: 5695 RVA: 0x00025198 File Offset: 0x00023398
		public new static vtkInteractorStyleTreeMapHover SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleTreeMapHover vtkInteractorStyleTreeMapHover = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleTreeMapHover = (vtkInteractorStyleTreeMapHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleTreeMapHover.Register(null);
				}
			}
			return vtkInteractorStyleTreeMapHover;
		}

		// Token: 0x06001640 RID: 5696
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightColor_17(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color used to highlight the hovered vertex.
		/// </summary>
		// Token: 0x06001641 RID: 5697 RVA: 0x00025217 File Offset: 0x00023417
		public void SetHighLightColor(double r, double g, double b)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetHighLightColor_17(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06001642 RID: 5698
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetHighLightWidth_18(HandleRef pThis, double lw);

		/// <summary>
		/// The width of the line around the hovered vertex.
		/// </summary>
		// Token: 0x06001643 RID: 5699 RVA: 0x00025229 File Offset: 0x00023429
		public void SetHighLightWidth(double lw)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetHighLightWidth_18(base.GetCppThis(), lw);
		}

		// Token: 0x06001644 RID: 5700
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetInteractor_19(HandleRef pThis, HandleRef rwi);

		/// <summary>
		/// Highlights a specific vertex.
		/// </summary>
		// Token: 0x06001645 RID: 5701 RVA: 0x0002523C File Offset: 0x0002343C
		public override void SetInteractor(vtkRenderWindowInteractor rwi)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetInteractor_19(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		// Token: 0x06001646 RID: 5702
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetLabelField_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the field to use when displaying text in the hover balloon.
		/// </summary>
		// Token: 0x06001647 RID: 5703 RVA: 0x0002526B File Offset: 0x0002346B
		public virtual void SetLabelField(string _arg)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetLabelField_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06001648 RID: 5704
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetLayout_21(HandleRef pThis, HandleRef layout);

		/// <summary>
		/// Must be set to the vtkTreeMapLayout used to compute the bounds of each vertex
		/// for the tree map.
		/// </summary>
		// Token: 0x06001649 RID: 5705 RVA: 0x0002527C File Offset: 0x0002347C
		public void SetLayout(vtkTreeMapLayout layout)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetLayout_21(base.GetCppThis(), (layout == null) ? default(HandleRef) : layout.GetCppThis());
		}

		// Token: 0x0600164A RID: 5706
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionLightColor_22(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color used to highlight the selected vertex.
		/// </summary>
		// Token: 0x0600164B RID: 5707 RVA: 0x000252AB File Offset: 0x000234AB
		public void SetSelectionLightColor(double r, double g, double b)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetSelectionLightColor_22(base.GetCppThis(), r, g, b);
		}

		// Token: 0x0600164C RID: 5708
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetSelectionWidth_23(HandleRef pThis, double lw);

		/// <summary>
		/// The width of the line around the selected vertex.
		/// </summary>
		// Token: 0x0600164D RID: 5709 RVA: 0x000252BD File Offset: 0x000234BD
		public void SetSelectionWidth(double lw)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetSelectionWidth_23(base.GetCppThis(), lw);
		}

		// Token: 0x0600164E RID: 5710
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_24(HandleRef pThis, HandleRef filter);

		/// <summary>
		/// Must be set to the vtkTreeMapToPolyData used to convert the tree map
		/// into polydata.
		/// </summary>
		// Token: 0x0600164F RID: 5711 RVA: 0x000252D0 File Offset: 0x000234D0
		public void SetTreeMapToPolyData(vtkTreeMapToPolyData filter)
		{
			vtkInteractorStyleTreeMapHover.vtkInteractorStyleTreeMapHover_SetTreeMapToPolyData_24(base.GetCppThis(), (filter == null) ? default(HandleRef) : filter.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000480 RID: 1152
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleTreeMapHover";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000481 RID: 1153
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleTreeMapHover";
	}
}
