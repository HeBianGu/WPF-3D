using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFreeTypeLabelRenderStrategy
	/// </summary>
	/// <remarks>
	///    Renders labels with freetype
	///
	///
	/// Uses the FreeType to render labels and compute label sizes.
	/// This strategy may be used with vtkLabelPlacementMapper.
	/// </remarks>
	// Token: 0x020000E6 RID: 230
	public class vtkFreeTypeLabelRenderStrategy : vtkLabelRenderStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002FBD RID: 12221 RVA: 0x00045DAA File Offset: 0x00043FAA
		static vtkFreeTypeLabelRenderStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFreeTypeLabelRenderStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeLabelRenderStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002FBE RID: 12222 RVA: 0x00045DD2 File Offset: 0x00043FD2
		public vtkFreeTypeLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002FBF RID: 12223
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FC0 RID: 12224 RVA: 0x00045DE0 File Offset: 0x00043FE0
		public new static vtkFreeTypeLabelRenderStrategy New()
		{
			vtkFreeTypeLabelRenderStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FC1 RID: 12225 RVA: 0x00045E34 File Offset: 0x00044034
		public vtkFreeTypeLabelRenderStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002FC2 RID: 12226 RVA: 0x00045E78 File Offset: 0x00044078
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002FC3 RID: 12227
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeLabelRenderStrategy_ComputeLabelBounds_01(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string label, IntPtr bds);

		/// <summary>
		/// Compute the bounds of a label. Must be performed after the renderer is set.
		/// </summary>
		// Token: 0x06002FC4 RID: 12228 RVA: 0x00045E84 File Offset: 0x00044084
		public override void ComputeLabelBounds(vtkTextProperty tprop, string label, IntPtr bds)
		{
			vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_ComputeLabelBounds_01(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), label, bds);
		}

		// Token: 0x06002FC5 RID: 12229
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FC6 RID: 12230 RVA: 0x00045EB8 File Offset: 0x000440B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002FC7 RID: 12231
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FC8 RID: 12232 RVA: 0x00045ED8 File Offset: 0x000440D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002FC9 RID: 12233
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeLabelRenderStrategy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FCA RID: 12234 RVA: 0x00045EF4 File Offset: 0x000440F4
		public override int IsA(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06002FCB RID: 12235
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFreeTypeLabelRenderStrategy_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FCC RID: 12236 RVA: 0x00045F14 File Offset: 0x00044114
		public new static int IsTypeOf(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_IsTypeOf_05(type);
		}

		// Token: 0x06002FCD RID: 12237
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FCE RID: 12238 RVA: 0x00045F30 File Offset: 0x00044130
		public new vtkFreeTypeLabelRenderStrategy NewInstance()
		{
			vtkFreeTypeLabelRenderStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002FCF RID: 12239
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this strategy.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002FD0 RID: 12240 RVA: 0x00045F8C File Offset: 0x0004418C
		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_08(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06002FD1 RID: 12241
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFreeTypeLabelRenderStrategy_RenderLabel_09(HandleRef pThis, IntPtr x, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Render a label at a location in world coordinates.
		/// Must be performed between StartFrame() and EndFrame() calls.
		/// </summary>
		// Token: 0x06002FD2 RID: 12242 RVA: 0x00045FBC File Offset: 0x000441BC
		public override void RenderLabel(IntPtr x, vtkTextProperty tprop, string label)
		{
			vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_RenderLabel_09(base.GetCppThis(), x, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), label);
		}

		// Token: 0x06002FD3 RID: 12243
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FD4 RID: 12244 RVA: 0x00045FF0 File Offset: 0x000441F0
		public new static vtkFreeTypeLabelRenderStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkFreeTypeLabelRenderStrategy vtkFreeTypeLabelRenderStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeLabelRenderStrategy = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeLabelRenderStrategy.Register(null);
				}
			}
			return vtkFreeTypeLabelRenderStrategy;
		}

		// Token: 0x06002FD5 RID: 12245
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_11(HandleRef pThis);

		/// <summary>
		/// The free type render strategy currently does not support bounded size labels.
		/// </summary>
		// Token: 0x06002FD6 RID: 12246 RVA: 0x00046070 File Offset: 0x00044270
		public override bool SupportsBoundedSize()
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06002FD7 RID: 12247
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsRotation_12(HandleRef pThis);

		/// <summary>
		/// The free type render strategy currently does not support rotation.
		/// </summary>
		// Token: 0x06002FD8 RID: 12248 RVA: 0x00046098 File Offset: 0x00044298
		public override bool SupportsRotation()
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SupportsRotation_12(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D1 RID: 1489
		public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeLabelRenderStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D2 RID: 1490
		public new static readonly string MRClassNameKey = "class vtkFreeTypeLabelRenderStrategy";
	}
}
