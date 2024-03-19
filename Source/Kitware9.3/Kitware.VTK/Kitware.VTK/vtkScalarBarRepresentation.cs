using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarBarRepresentation
	/// </summary>
	/// <remarks>
	///    represent scalar bar for vtkScalarBarWidget
	///
	///
	///
	/// This class represents a scalar bar for a vtkScalarBarWidget.  This class
	/// provides support for interactively placing a scalar bar on the 2D overlay
	/// plane.  The scalar bar is defined by an instance of vtkScalarBarActor.
	///
	/// One specialty of this class is that if the scalar bar is moved near enough
	/// to an edge, it's orientation is flipped to match that edge.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkScalarBarWidget vtkWidgetRepresentation vtkScalarBarActor
	///
	/// </seealso>
	// Token: 0x0200036F RID: 879
	public class vtkScalarBarRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009F81 RID: 40833 RVA: 0x000E24DF File Offset: 0x000E06DF
		static vtkScalarBarRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009F82 RID: 40834 RVA: 0x000E2507 File Offset: 0x000E0707
		public vtkScalarBarRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009F83 RID: 40835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F84 RID: 40836 RVA: 0x000E2518 File Offset: 0x000E0718
		public new static vtkScalarBarRepresentation New()
		{
			vtkScalarBarRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F85 RID: 40837 RVA: 0x000E256C File Offset: 0x000E076C
		public vtkScalarBarRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScalarBarRepresentation.vtkScalarBarRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009F86 RID: 40838 RVA: 0x000E25B0 File Offset: 0x000E07B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009F87 RID: 40839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009F88 RID: 40840 RVA: 0x000E25BB File Offset: 0x000E07BB
		public override void BuildRepresentation()
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009F89 RID: 40841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_GetActors2D_02(HandleRef pThis, HandleRef collection);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009F8A RID: 40842 RVA: 0x000E25CC File Offset: 0x000E07CC
		public override void GetActors2D(vtkPropCollection collection)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetActors2D_02(base.GetCppThis(), (collection == null) ? default(HandleRef) : collection.GetCppThis());
		}

		// Token: 0x06009F8B RID: 40843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarBarRepresentation_GetAutoOrient_03(HandleRef pThis);

		/// <summary>
		/// If true, the orientation will be updated based on the widget's position.
		/// Default is true.
		/// </summary>
		// Token: 0x06009F8C RID: 40844 RVA: 0x000E25FC File Offset: 0x000E07FC
		public virtual bool GetAutoOrient()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetAutoOrient_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06009F8D RID: 40845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F8E RID: 40846 RVA: 0x000E2624 File Offset: 0x000E0824
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06009F8F RID: 40847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarBarRepresentation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F90 RID: 40848 RVA: 0x000E2644 File Offset: 0x000E0844
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06009F91 RID: 40849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_GetOrientation_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the orientation.
		/// </summary>
		// Token: 0x06009F92 RID: 40850 RVA: 0x000E2660 File Offset: 0x000E0860
		public int GetOrientation()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetOrientation_06(base.GetCppThis());
		}

		// Token: 0x06009F93 RID: 40851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarRepresentation_GetScalarBarActor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The prop that is placed in the renderer.
		/// </summary>
		// Token: 0x06009F94 RID: 40852 RVA: 0x000E2680 File Offset: 0x000E0880
		public virtual vtkScalarBarActor GetScalarBarActor()
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetScalarBarActor_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		// Token: 0x06009F95 RID: 40853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_GetSize_08(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009F96 RID: 40854 RVA: 0x000E26EF File Offset: 0x000E08EF
		public override void GetSize(IntPtr size)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetSize_08(base.GetCppThis(), size);
		}

		// Token: 0x06009F97 RID: 40855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_GetVisibility_09(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009F98 RID: 40856 RVA: 0x000E2700 File Offset: 0x000E0900
		public override int GetVisibility()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetVisibility_09(base.GetCppThis());
		}

		// Token: 0x06009F99 RID: 40857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009F9A RID: 40858 RVA: 0x000E2720 File Offset: 0x000E0920
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_HasTranslucentPolygonalGeometry_10(base.GetCppThis());
		}

		// Token: 0x06009F9B RID: 40859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F9C RID: 40860 RVA: 0x000E2740 File Offset: 0x000E0940
		public override int IsA(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06009F9D RID: 40861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F9E RID: 40862 RVA: 0x000E2760 File Offset: 0x000E0960
		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_IsTypeOf_12(type);
		}

		// Token: 0x06009F9F RID: 40863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarRepresentation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FA0 RID: 40864 RVA: 0x000E277C File Offset: 0x000E097C
		public new vtkScalarBarRepresentation NewInstance()
		{
			vtkScalarBarRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009FA1 RID: 40865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef window);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009FA2 RID: 40866 RVA: 0x000E27D8 File Offset: 0x000E09D8
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_ReleaseGraphicsResources_15(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06009FA3 RID: 40867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009FA4 RID: 40868 RVA: 0x000E2808 File Offset: 0x000E0A08
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderOpaqueGeometry_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009FA5 RID: 40869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_RenderOverlay_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009FA6 RID: 40870 RVA: 0x000E283C File Offset: 0x000E0A3C
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderOverlay_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009FA7 RID: 40871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarBarRepresentation_RenderTranslucentPolygonalGeometry_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009FA8 RID: 40872 RVA: 0x000E2870 File Offset: 0x000E0A70
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderTranslucentPolygonalGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009FA9 RID: 40873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarBarRepresentation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009FAA RID: 40874 RVA: 0x000E28A4 File Offset: 0x000E0AA4
		public new static vtkScalarBarRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarRepresentation vtkScalarBarRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarRepresentation = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarRepresentation.Register(null);
				}
			}
			return vtkScalarBarRepresentation;
		}

		// Token: 0x06009FAB RID: 40875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_SetAutoOrient_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, the orientation will be updated based on the widget's position.
		/// Default is true.
		/// </summary>
		// Token: 0x06009FAC RID: 40876 RVA: 0x000E2923 File Offset: 0x000E0B23
		public virtual void SetAutoOrient(bool _arg)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetAutoOrient_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06009FAD RID: 40877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_SetOrientation_21(HandleRef pThis, int orient);

		/// <summary>
		/// Get/Set the orientation.
		/// </summary>
		// Token: 0x06009FAE RID: 40878 RVA: 0x000E293B File Offset: 0x000E0B3B
		public void SetOrientation(int orient)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetOrientation_21(base.GetCppThis(), orient);
		}

		// Token: 0x06009FAF RID: 40879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_SetScalarBarActor_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The prop that is placed in the renderer.
		/// </summary>
		// Token: 0x06009FB0 RID: 40880 RVA: 0x000E294C File Offset: 0x000E0B4C
		public virtual void SetScalarBarActor(vtkScalarBarActor arg0)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetScalarBarActor_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009FB1 RID: 40881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_SetVisibility_23(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009FB2 RID: 40882 RVA: 0x000E297B File Offset: 0x000E0B7B
		public override void SetVisibility(int arg0)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetVisibility_23(base.GetCppThis(), arg0);
		}

		// Token: 0x06009FB3 RID: 40883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarBarRepresentation_WidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009FB4 RID: 40884 RVA: 0x000E298B File Offset: 0x000E0B8B
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_WidgetInteraction_24(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE4 RID: 3300
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CE5 RID: 3301
		public new static readonly string MRClassNameKey = "class vtkScalarBarRepresentation";
	}
}
