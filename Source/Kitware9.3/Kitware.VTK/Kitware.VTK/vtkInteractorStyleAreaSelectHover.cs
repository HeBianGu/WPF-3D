using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleAreaSelectHover
	/// </summary>
	/// <remarks>
	///    An interactor style for an area tree view
	///
	///
	/// The vtkInteractorStyleAreaSelectHover specifically works with pipelines
	/// that create a hierarchical tree.  Such pipelines will have a vtkAreaLayout
	/// filter which must be passed to this interactor style for it to function
	/// correctly.
	/// This interactor style allows only 2D panning and zooming,
	/// rubber band selection and provides a balloon containing the name of the
	/// vertex hovered over.
	/// </remarks>
	// Token: 0x02000074 RID: 116
	public class vtkInteractorStyleAreaSelectHover : vtkInteractorStyleRubberBand2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600152A RID: 5418 RVA: 0x00023E57 File Offset: 0x00022057
		static vtkInteractorStyleAreaSelectHover()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleAreaSelectHover.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleAreaSelectHover"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600152B RID: 5419 RVA: 0x00023E7F File Offset: 0x0002207F
		public vtkInteractorStyleAreaSelectHover(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600152C RID: 5420
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600152D RID: 5421 RVA: 0x00023E90 File Offset: 0x00022090
		public new static vtkInteractorStyleAreaSelectHover New()
		{
			vtkInteractorStyleAreaSelectHover result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600152E RID: 5422 RVA: 0x00023EE4 File Offset: 0x000220E4
		public vtkInteractorStyleAreaSelectHover() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600152F RID: 5423 RVA: 0x00023F28 File Offset: 0x00022128
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001530 RID: 5424
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(HandleRef pThis);

		/// <summary>
		/// The width of the line around the hovered vertex.
		/// </summary>
		// Token: 0x06001531 RID: 5425 RVA: 0x00023F34 File Offset: 0x00022134
		public double GetHighLightWidth()
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetHighLightWidth_01(base.GetCppThis());
		}

		// Token: 0x06001532 RID: 5426
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(HandleRef pThis, int x, int y);

		/// <summary>
		/// Obtain the tree vertex id at the position specified.
		/// </summary>
		// Token: 0x06001533 RID: 5427 RVA: 0x00023F54 File Offset: 0x00022154
		public long GetIdAtPos(int x, int y)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetIdAtPos_02(base.GetCppThis(), x, y);
		}

		// Token: 0x06001534 RID: 5428
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLabelField_03(HandleRef pThis);

		/// <summary>
		/// The name of the field to use when displaying text in the hover balloon.
		/// </summary>
		// Token: 0x06001535 RID: 5429 RVA: 0x00023F78 File Offset: 0x00022178
		public virtual string GetLabelField()
		{
			string s = Marshal.PtrToStringAnsi(vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetLabelField_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001536 RID: 5430
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_GetLayout_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Must be set to the vtkAreaLayout used to compute the bounds of
		/// each vertex.
		/// </summary>
		// Token: 0x06001537 RID: 5431 RVA: 0x00023FB4 File Offset: 0x000221B4
		public virtual vtkAreaLayout GetLayout()
		{
			vtkAreaLayout vtkAreaLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetLayout_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayout = (vtkAreaLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayout.Register(null);
				}
			}
			return vtkAreaLayout;
		}

		// Token: 0x06001538 RID: 5432
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001539 RID: 5433 RVA: 0x00024024 File Offset: 0x00022224
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600153A RID: 5434
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600153B RID: 5435 RVA: 0x00024044 File Offset: 0x00022244
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600153C RID: 5436
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_07(HandleRef pThis);

		/// <summary>
		/// Determine whether or not to use rectangular coordinates instead of
		/// polar coordinates.
		/// </summary>
		// Token: 0x0600153D RID: 5437 RVA: 0x00024060 File Offset: 0x00022260
		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_GetUseRectangularCoordinates_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600153E RID: 5438
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleAreaSelectHover_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600153F RID: 5439 RVA: 0x00024088 File Offset: 0x00022288
		public override int IsA(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06001540 RID: 5440
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleAreaSelectHover_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001541 RID: 5441 RVA: 0x000240A8 File Offset: 0x000222A8
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_IsTypeOf_09(type);
		}

		// Token: 0x06001542 RID: 5442
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001543 RID: 5443 RVA: 0x000240C4 File Offset: 0x000222C4
		public new vtkInteractorStyleAreaSelectHover NewInstance()
		{
			vtkInteractorStyleAreaSelectHover result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001544 RID: 5444
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_OnMouseMove_12(HandleRef pThis);

		/// <summary>
		/// Overridden from vtkInteractorStyleImage to provide the desired
		/// interaction behavior.
		/// </summary>
		// Token: 0x06001545 RID: 5445 RVA: 0x0002411E File Offset: 0x0002231E
		public override void OnMouseMove()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_OnMouseMove_12(base.GetCppThis());
		}

		// Token: 0x06001546 RID: 5446
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleAreaSelectHover_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001547 RID: 5447 RVA: 0x00024130 File Offset: 0x00022330
		public new static vtkInteractorStyleAreaSelectHover SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleAreaSelectHover vtkInteractorStyleAreaSelectHover = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleAreaSelectHover = (vtkInteractorStyleAreaSelectHover)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleAreaSelectHover.Register(null);
				}
			}
			return vtkInteractorStyleAreaSelectHover;
		}

		// Token: 0x06001548 RID: 5448
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightColor_14(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color used to highlight the hovered vertex.
		/// </summary>
		// Token: 0x06001549 RID: 5449 RVA: 0x000241AF File Offset: 0x000223AF
		public void SetHighLightColor(double r, double g, double b)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetHighLightColor_14(base.GetCppThis(), r, g, b);
		}

		// Token: 0x0600154A RID: 5450
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetHighLightWidth_15(HandleRef pThis, double lw);

		/// <summary>
		/// The width of the line around the hovered vertex.
		/// </summary>
		// Token: 0x0600154B RID: 5451 RVA: 0x000241C1 File Offset: 0x000223C1
		public void SetHighLightWidth(double lw)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetHighLightWidth_15(base.GetCppThis(), lw);
		}

		// Token: 0x0600154C RID: 5452
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetInteractor_16(HandleRef pThis, HandleRef rwi);

		/// <summary>
		/// Set the interactor that this interactor style works with.
		/// </summary>
		// Token: 0x0600154D RID: 5453 RVA: 0x000241D4 File Offset: 0x000223D4
		public override void SetInteractor(vtkRenderWindowInteractor rwi)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetInteractor_16(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		// Token: 0x0600154E RID: 5454
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetLabelField_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the field to use when displaying text in the hover balloon.
		/// </summary>
		// Token: 0x0600154F RID: 5455 RVA: 0x00024203 File Offset: 0x00022403
		public virtual void SetLabelField(string _arg)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetLabelField_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06001550 RID: 5456
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetLayout_18(HandleRef pThis, HandleRef layout);

		/// <summary>
		/// Must be set to the vtkAreaLayout used to compute the bounds of
		/// each vertex.
		/// </summary>
		// Token: 0x06001551 RID: 5457 RVA: 0x00024214 File Offset: 0x00022414
		public void SetLayout(vtkAreaLayout layout)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetLayout_18(base.GetCppThis(), (layout == null) ? default(HandleRef) : layout.GetCppThis());
		}

		// Token: 0x06001552 RID: 5458
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Determine whether or not to use rectangular coordinates instead of
		/// polar coordinates.
		/// </summary>
		// Token: 0x06001553 RID: 5459 RVA: 0x00024243 File Offset: 0x00022443
		public virtual void SetUseRectangularCoordinates(bool _arg)
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_SetUseRectangularCoordinates_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001554 RID: 5460
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_20(HandleRef pThis);

		/// <summary>
		/// Determine whether or not to use rectangular coordinates instead of
		/// polar coordinates.
		/// </summary>
		// Token: 0x06001555 RID: 5461 RVA: 0x0002425B File Offset: 0x0002245B
		public virtual void UseRectangularCoordinatesOff()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOff_20(base.GetCppThis());
		}

		// Token: 0x06001556 RID: 5462
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_21(HandleRef pThis);

		/// <summary>
		/// Determine whether or not to use rectangular coordinates instead of
		/// polar coordinates.
		/// </summary>
		// Token: 0x06001557 RID: 5463 RVA: 0x0002426A File Offset: 0x0002246A
		public virtual void UseRectangularCoordinatesOn()
		{
			vtkInteractorStyleAreaSelectHover.vtkInteractorStyleAreaSelectHover_UseRectangularCoordinatesOn_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047A RID: 1146
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleAreaSelectHover";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047B RID: 1147
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleAreaSelectHover";
	}
}
