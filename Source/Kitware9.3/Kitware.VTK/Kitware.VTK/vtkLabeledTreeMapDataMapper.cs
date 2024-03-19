using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabeledTreeMapDataMapper
	/// </summary>
	/// <remarks>
	///    draw text labels on a tree map
	///
	///
	/// vtkLabeledTreeMapDataMapper is a mapper that renders text on a tree map.
	/// A tree map is a vtkTree with an associated 4-tuple array
	/// used for storing the boundary rectangle for each vertex in the tree.
	/// The user must specify the array name used for storing the rectangles.
	///
	/// The mapper iterates through the tree and attempts and renders a label
	/// inside the vertex's rectangle as long as the following conditions hold:
	/// 1. The vertex level is within the range of levels specified for labeling.
	/// 2. The label can fully fit inside its box.
	/// 3. The label does not overlap an ancestor's label.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLabeledDataMapper
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </seealso>
	// Token: 0x020000E7 RID: 231
	public class vtkLabeledTreeMapDataMapper : vtkLabeledDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002FD9 RID: 12249 RVA: 0x000460BE File Offset: 0x000442BE
		static vtkLabeledTreeMapDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledTreeMapDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledTreeMapDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002FDA RID: 12250 RVA: 0x000460E6 File Offset: 0x000442E6
		public vtkLabeledTreeMapDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002FDB RID: 12251
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FDC RID: 12252 RVA: 0x000460F4 File Offset: 0x000442F4
		public new static vtkLabeledTreeMapDataMapper New()
		{
			vtkLabeledTreeMapDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FDD RID: 12253 RVA: 0x00046148 File Offset: 0x00044348
		public vtkLabeledTreeMapDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002FDE RID: 12254 RVA: 0x0004618C File Offset: 0x0004438C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002FDF RID: 12255
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledTreeMapDataMapper_GetChildMotion_01(HandleRef pThis);

		/// <summary>
		/// Indicates if the label can be moved by its ancestors
		/// </summary>
		// Token: 0x06002FE0 RID: 12256 RVA: 0x00046198 File Offset: 0x00044398
		public virtual int GetChildMotion()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetChildMotion_01(base.GetCppThis());
		}

		// Token: 0x06002FE1 RID: 12257
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledTreeMapDataMapper_GetClipTextMode_02(HandleRef pThis);

		/// <summary>
		/// Indicates if the label can be displayed clipped by the Window
		/// mode = 0 - ok to clip labels
		/// 1 - auto center labels w/r to the area of the vertex's clipped region
		/// </summary>
		// Token: 0x06002FE2 RID: 12258 RVA: 0x000461B8 File Offset: 0x000443B8
		public virtual int GetClipTextMode()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetClipTextMode_02(base.GetCppThis());
		}

		// Token: 0x06002FE3 RID: 12259
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(HandleRef pThis);

		/// <summary>
		/// Indicates at which level labeling should be dynamic
		/// </summary>
		// Token: 0x06002FE4 RID: 12260 RVA: 0x000461D8 File Offset: 0x000443D8
		public virtual int GetDynamicLevel()
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetDynamicLevel_03(base.GetCppThis());
		}

		// Token: 0x06002FE5 RID: 12261
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(HandleRef pThis, IntPtr range);

		/// <summary>
		/// The range of font sizes to use when rendering the labels.
		/// </summary>
		// Token: 0x06002FE6 RID: 12262 RVA: 0x000461F7 File Offset: 0x000443F7
		public void GetFontSizeRange(IntPtr range)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetFontSizeRange_04(base.GetCppThis(), range);
		}

		// Token: 0x06002FE7 RID: 12263
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_GetInputTree_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input to this filter.
		/// </summary>
		// Token: 0x06002FE8 RID: 12264 RVA: 0x00046208 File Offset: 0x00044408
		public virtual vtkTree GetInputTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetInputTree_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06002FE9 RID: 12265
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_GetLevelRange_06(HandleRef pThis, IntPtr range);

		/// <summary>
		/// The range of levels to attempt to label.
		/// The level of a vertex is the length of the path to the root
		/// (the root has level 0).
		/// </summary>
		// Token: 0x06002FEA RID: 12266 RVA: 0x00046277 File Offset: 0x00044477
		public void GetLevelRange(IntPtr range)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetLevelRange_06(base.GetCppThis(), range);
		}

		// Token: 0x06002FEB RID: 12267
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FEC RID: 12268 RVA: 0x00046288 File Offset: 0x00044488
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06002FED RID: 12269
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FEE RID: 12270 RVA: 0x000462A8 File Offset: 0x000444A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06002FEF RID: 12271
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledTreeMapDataMapper_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FF0 RID: 12272 RVA: 0x000462C4 File Offset: 0x000444C4
		public override int IsA(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06002FF1 RID: 12273
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledTreeMapDataMapper_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FF2 RID: 12274 RVA: 0x000462E4 File Offset: 0x000444E4
		public new static int IsTypeOf(string type)
		{
			return vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_IsTypeOf_10(type);
		}

		// Token: 0x06002FF3 RID: 12275
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FF4 RID: 12276 RVA: 0x00046300 File Offset: 0x00044500
		public new vtkLabeledTreeMapDataMapper NewInstance()
		{
			vtkLabeledTreeMapDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002FF5 RID: 12277
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// </summary>
		// Token: 0x06002FF6 RID: 12278 RVA: 0x0004635C File Offset: 0x0004455C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002FF7 RID: 12279
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_14(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw the text to the screen at each input point.
		/// </summary>
		// Token: 0x06002FF8 RID: 12280 RVA: 0x0004638C File Offset: 0x0004458C
		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_RenderOpaqueGeometry_14(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002FF9 RID: 12281
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_RenderOverlay_15(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw the text to the screen at each input point.
		/// </summary>
		// Token: 0x06002FFA RID: 12282 RVA: 0x000463D0 File Offset: 0x000445D0
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_RenderOverlay_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002FFB RID: 12283
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledTreeMapDataMapper_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002FFC RID: 12284 RVA: 0x00046414 File Offset: 0x00044614
		public new static vtkLabeledTreeMapDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledTreeMapDataMapper vtkLabeledTreeMapDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledTreeMapDataMapper = (vtkLabeledTreeMapDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledTreeMapDataMapper.Register(null);
				}
			}
			return vtkLabeledTreeMapDataMapper;
		}

		// Token: 0x06002FFD RID: 12285
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetChildMotion_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicates if the label can be moved by its ancestors
		/// </summary>
		// Token: 0x06002FFE RID: 12286 RVA: 0x00046493 File Offset: 0x00044693
		public virtual void SetChildMotion(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetChildMotion_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06002FFF RID: 12287
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetClipTextMode_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicates if the label can be displayed clipped by the Window
		/// mode = 0 - ok to clip labels
		/// 1 - auto center labels w/r to the area of the vertex's clipped region
		/// </summary>
		// Token: 0x06003000 RID: 12288 RVA: 0x000464A3 File Offset: 0x000446A3
		public virtual void SetClipTextMode(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetClipTextMode_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06003001 RID: 12289
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetDynamicLevel_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicates at which level labeling should be dynamic
		/// </summary>
		// Token: 0x06003002 RID: 12290 RVA: 0x000464B3 File Offset: 0x000446B3
		public virtual void SetDynamicLevel(int _arg)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetDynamicLevel_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06003003 RID: 12291
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetFontSizeRange_20(HandleRef pThis, int maxSize, int minSize, int delta);

		/// <summary>
		/// The range of font sizes to use when rendering the labels.
		/// </summary>
		// Token: 0x06003004 RID: 12292 RVA: 0x000464C3 File Offset: 0x000446C3
		public void SetFontSizeRange(int maxSize, int minSize, int delta)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetFontSizeRange_20(base.GetCppThis(), maxSize, minSize, delta);
		}

		// Token: 0x06003005 RID: 12293
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetLevelRange_21(HandleRef pThis, int startLevel, int endLevel);

		/// <summary>
		/// The range of levels to attempt to label.
		/// The level of a vertex is the length of the path to the root
		/// (the root has level 0).
		/// </summary>
		// Token: 0x06003006 RID: 12294 RVA: 0x000464D5 File Offset: 0x000446D5
		public void SetLevelRange(int startLevel, int endLevel)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetLevelRange_21(base.GetCppThis(), startLevel, endLevel);
		}

		// Token: 0x06003007 RID: 12295
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The name of the 4-tuple array used for
		/// </summary>
		// Token: 0x06003008 RID: 12296 RVA: 0x000464E6 File Offset: 0x000446E6
		public virtual void SetRectanglesArrayName(string name)
		{
			vtkLabeledTreeMapDataMapper.vtkLabeledTreeMapDataMapper_SetRectanglesArrayName_22(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D3 RID: 1491
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledTreeMapDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D4 RID: 1492
		public new static readonly string MRClassNameKey = "class vtkLabeledTreeMapDataMapper";
	}
}
