using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIcicleView
	/// </summary>
	/// <remarks>
	///    Displays a tree in a stacked "icicle" view
	///
	///
	/// vtkIcicleView shows a vtkTree in horizontal layers
	/// where each vertex in the tree is represented by a bar.
	/// Child sectors are below (or above) parent sectors, and may be
	/// colored and sized by various parameters.
	/// </remarks>
	// Token: 0x02000070 RID: 112
	public class vtkIcicleView : vtkTreeAreaView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060014C6 RID: 5318 RVA: 0x000236FF File Offset: 0x000218FF
		static vtkIcicleView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIcicleView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIcicleView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060014C7 RID: 5319 RVA: 0x00023727 File Offset: 0x00021927
		public vtkIcicleView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060014C8 RID: 5320
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIcicleView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014C9 RID: 5321 RVA: 0x00023738 File Offset: 0x00021938
		public new static vtkIcicleView New()
		{
			vtkIcicleView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014CA RID: 5322 RVA: 0x0002378C File Offset: 0x0002198C
		public vtkIcicleView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIcicleView.vtkIcicleView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060014CB RID: 5323 RVA: 0x000237D0 File Offset: 0x000219D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060014CC RID: 5324
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIcicleView_GetLayerThickness_01(HandleRef pThis);

		/// <summary>
		/// Set the thickness of each layer
		/// </summary>
		// Token: 0x060014CD RID: 5325 RVA: 0x000237DC File Offset: 0x000219DC
		public virtual double GetLayerThickness()
		{
			return vtkIcicleView.vtkIcicleView_GetLayerThickness_01(base.GetCppThis());
		}

		// Token: 0x060014CE RID: 5326
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIcicleView_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014CF RID: 5327 RVA: 0x000237FC File Offset: 0x000219FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIcicleView.vtkIcicleView_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060014D0 RID: 5328
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIcicleView_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014D1 RID: 5329 RVA: 0x0002381C File Offset: 0x00021A1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIcicleView.vtkIcicleView_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060014D2 RID: 5330
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIcicleView_GetRootWidth_04(HandleRef pThis);

		/// <summary>
		/// Set the width of the root node
		/// </summary>
		// Token: 0x060014D3 RID: 5331 RVA: 0x00023838 File Offset: 0x00021A38
		public virtual double GetRootWidth()
		{
			return vtkIcicleView.vtkIcicleView_GetRootWidth_04(base.GetCppThis());
		}

		// Token: 0x060014D4 RID: 5332
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIcicleView_GetTopToBottom_05(HandleRef pThis);

		/// <summary>
		/// Sets whether the stacks go from top to bottom or bottom to top.
		/// </summary>
		// Token: 0x060014D5 RID: 5333 RVA: 0x00023858 File Offset: 0x00021A58
		public virtual bool GetTopToBottom()
		{
			return vtkIcicleView.vtkIcicleView_GetTopToBottom_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060014D6 RID: 5334
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIcicleView_GetUseGradientColoring_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off gradient coloring.
		/// </summary>
		// Token: 0x060014D7 RID: 5335 RVA: 0x00023880 File Offset: 0x00021A80
		public virtual bool GetUseGradientColoring()
		{
			return vtkIcicleView.vtkIcicleView_GetUseGradientColoring_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060014D8 RID: 5336
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIcicleView_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014D9 RID: 5337 RVA: 0x000238A8 File Offset: 0x00021AA8
		public override int IsA(string type)
		{
			return vtkIcicleView.vtkIcicleView_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060014DA RID: 5338
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIcicleView_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014DB RID: 5339 RVA: 0x000238C8 File Offset: 0x00021AC8
		public new static int IsTypeOf(string type)
		{
			return vtkIcicleView.vtkIcicleView_IsTypeOf_08(type);
		}

		// Token: 0x060014DC RID: 5340
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIcicleView_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014DD RID: 5341 RVA: 0x000238E4 File Offset: 0x00021AE4
		public new vtkIcicleView NewInstance()
		{
			vtkIcicleView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060014DE RID: 5342
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIcicleView_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014DF RID: 5343 RVA: 0x00023940 File Offset: 0x00021B40
		public new static vtkIcicleView SafeDownCast(vtkObjectBase o)
		{
			vtkIcicleView vtkIcicleView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIcicleView.vtkIcicleView_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIcicleView = (vtkIcicleView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIcicleView.Register(null);
				}
			}
			return vtkIcicleView;
		}

		// Token: 0x060014E0 RID: 5344
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_SetLayerThickness_12(HandleRef pThis, double thickness);

		/// <summary>
		/// Set the thickness of each layer
		/// </summary>
		// Token: 0x060014E1 RID: 5345 RVA: 0x000239BF File Offset: 0x00021BBF
		public virtual void SetLayerThickness(double thickness)
		{
			vtkIcicleView.vtkIcicleView_SetLayerThickness_12(base.GetCppThis(), thickness);
		}

		// Token: 0x060014E2 RID: 5346
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_SetRootWidth_13(HandleRef pThis, double width);

		/// <summary>
		/// Set the width of the root node
		/// </summary>
		// Token: 0x060014E3 RID: 5347 RVA: 0x000239CF File Offset: 0x00021BCF
		public virtual void SetRootWidth(double width)
		{
			vtkIcicleView.vtkIcicleView_SetRootWidth_13(base.GetCppThis(), width);
		}

		// Token: 0x060014E4 RID: 5348
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_SetTopToBottom_14(HandleRef pThis, byte reversed);

		/// <summary>
		/// Sets whether the stacks go from top to bottom or bottom to top.
		/// </summary>
		// Token: 0x060014E5 RID: 5349 RVA: 0x000239DF File Offset: 0x00021BDF
		public virtual void SetTopToBottom(bool reversed)
		{
			vtkIcicleView.vtkIcicleView_SetTopToBottom_14(base.GetCppThis(), reversed ? (byte)1 : (byte)0);
		}

		// Token: 0x060014E6 RID: 5350
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_SetUseGradientColoring_15(HandleRef pThis, byte value);

		/// <summary>
		/// Turn on/off gradient coloring.
		/// </summary>
		// Token: 0x060014E7 RID: 5351 RVA: 0x000239F7 File Offset: 0x00021BF7
		public virtual void SetUseGradientColoring(bool value)
		{
			vtkIcicleView.vtkIcicleView_SetUseGradientColoring_15(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		// Token: 0x060014E8 RID: 5352
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_TopToBottomOff_16(HandleRef pThis);

		/// <summary>
		/// Sets whether the stacks go from top to bottom or bottom to top.
		/// </summary>
		// Token: 0x060014E9 RID: 5353 RVA: 0x00023A0F File Offset: 0x00021C0F
		public virtual void TopToBottomOff()
		{
			vtkIcicleView.vtkIcicleView_TopToBottomOff_16(base.GetCppThis());
		}

		// Token: 0x060014EA RID: 5354
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_TopToBottomOn_17(HandleRef pThis);

		/// <summary>
		/// Sets whether the stacks go from top to bottom or bottom to top.
		/// </summary>
		// Token: 0x060014EB RID: 5355 RVA: 0x00023A1E File Offset: 0x00021C1E
		public virtual void TopToBottomOn()
		{
			vtkIcicleView.vtkIcicleView_TopToBottomOn_17(base.GetCppThis());
		}

		// Token: 0x060014EC RID: 5356
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_UseGradientColoringOff_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off gradient coloring.
		/// </summary>
		// Token: 0x060014ED RID: 5357 RVA: 0x00023A2D File Offset: 0x00021C2D
		public virtual void UseGradientColoringOff()
		{
			vtkIcicleView.vtkIcicleView_UseGradientColoringOff_18(base.GetCppThis());
		}

		// Token: 0x060014EE RID: 5358
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIcicleView_UseGradientColoringOn_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off gradient coloring.
		/// </summary>
		// Token: 0x060014EF RID: 5359 RVA: 0x00023A3C File Offset: 0x00021C3C
		public virtual void UseGradientColoringOn()
		{
			vtkIcicleView.vtkIcicleView_UseGradientColoringOn_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046E RID: 1134
		public new const string MRFullTypeName = "Kitware.VTK.vtkIcicleView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046F RID: 1135
		public new static readonly string MRClassNameKey = "class vtkIcicleView";
	}
}
