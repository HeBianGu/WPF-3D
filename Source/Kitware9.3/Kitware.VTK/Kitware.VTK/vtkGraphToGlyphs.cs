using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphToGlyphs
	/// </summary>
	/// <remarks>
	///    create glyphs for graph vertices
	///
	///
	/// Converts a vtkGraph to a vtkPolyData containing a glyph for each vertex.
	/// This assumes that the points
	/// of the graph have already been filled (perhaps by vtkGraphLayout).
	/// The glyphs will automatically be scaled to be the same size in screen
	/// coordinates. To do this the filter requires a pointer to the renderer
	/// into which the glyphs will be rendered.
	/// </remarks>
	// Token: 0x020007E3 RID: 2019
	public class vtkGraphToGlyphs : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014C12 RID: 85010 RVA: 0x001D5EB3 File Offset: 0x001D40B3
		static vtkGraphToGlyphs()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphToGlyphs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToGlyphs"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014C13 RID: 85011 RVA: 0x001D5EDB File Offset: 0x001D40DB
		public vtkGraphToGlyphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014C14 RID: 85012
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToGlyphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C15 RID: 85013 RVA: 0x001D5EEC File Offset: 0x001D40EC
		public new static vtkGraphToGlyphs New()
		{
			vtkGraphToGlyphs result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C16 RID: 85014 RVA: 0x001D5F40 File Offset: 0x001D4140
		public vtkGraphToGlyphs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphToGlyphs.vtkGraphToGlyphs_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014C17 RID: 85015 RVA: 0x001D5F84 File Offset: 0x001D4184
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014C18 RID: 85016
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_FilledOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to fill the glyph, or to just render the outline.
		/// </summary>
		// Token: 0x06014C19 RID: 85017 RVA: 0x001D5F8F File Offset: 0x001D418F
		public virtual void FilledOff()
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_FilledOff_01(base.GetCppThis());
		}

		// Token: 0x06014C1A RID: 85018
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_FilledOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to fill the glyph, or to just render the outline.
		/// </summary>
		// Token: 0x06014C1B RID: 85019 RVA: 0x001D5F9E File Offset: 0x001D419E
		public virtual void FilledOn()
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_FilledOn_02(base.GetCppThis());
		}

		// Token: 0x06014C1C RID: 85020
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphToGlyphs_GetFilled_03(HandleRef pThis);

		/// <summary>
		/// Whether to fill the glyph, or to just render the outline.
		/// </summary>
		// Token: 0x06014C1D RID: 85021 RVA: 0x001D5FB0 File Offset: 0x001D41B0
		public virtual bool GetFilled()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetFilled_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06014C1E RID: 85022
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToGlyphs_GetGlyphType_04(HandleRef pThis);

		/// <summary>
		/// The glyph type, specified as one of the enumerated values in this
		/// class. VERTEX is a special glyph that cannot be scaled, but instead
		/// is rendered as an OpenGL vertex primitive. This may appear as a box
		/// or circle depending on the hardware.
		/// </summary>
		// Token: 0x06014C1F RID: 85023 RVA: 0x001D5FD8 File Offset: 0x001D41D8
		public virtual int GetGlyphType()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetGlyphType_04(base.GetCppThis());
		}

		// Token: 0x06014C20 RID: 85024
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGraphToGlyphs_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// The modified time of this filter.
		/// </summary>
		// Token: 0x06014C21 RID: 85025 RVA: 0x001D5FF8 File Offset: 0x001D41F8
		public override ulong GetMTime()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06014C22 RID: 85026
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToGlyphs_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C23 RID: 85027 RVA: 0x001D6018 File Offset: 0x001D4218
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06014C24 RID: 85028
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToGlyphs_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C25 RID: 85029 RVA: 0x001D6038 File Offset: 0x001D4238
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06014C26 RID: 85030
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToGlyphs_GetRenderer_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The renderer in which the glyphs will be placed.
		/// </summary>
		// Token: 0x06014C27 RID: 85031 RVA: 0x001D6054 File Offset: 0x001D4254
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_GetRenderer_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06014C28 RID: 85032
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphToGlyphs_GetScaling_09(HandleRef pThis);

		/// <summary>
		/// Whether to use the input array to process in order to scale the
		/// vertices.
		/// </summary>
		// Token: 0x06014C29 RID: 85033 RVA: 0x001D60C4 File Offset: 0x001D42C4
		public virtual bool GetScaling()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetScaling_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06014C2A RID: 85034
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphToGlyphs_GetScreenSize_10(HandleRef pThis);

		/// <summary>
		/// Set the desired screen size of each glyph. If you are using scaling,
		/// this will be the size of the glyph when rendering an object with
		/// scaling value 1.0.
		/// </summary>
		// Token: 0x06014C2B RID: 85035 RVA: 0x001D60EC File Offset: 0x001D42EC
		public virtual double GetScreenSize()
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_GetScreenSize_10(base.GetCppThis());
		}

		// Token: 0x06014C2C RID: 85036
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToGlyphs_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C2D RID: 85037 RVA: 0x001D610C File Offset: 0x001D430C
		public override int IsA(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06014C2E RID: 85038
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToGlyphs_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C2F RID: 85039 RVA: 0x001D612C File Offset: 0x001D432C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphToGlyphs.vtkGraphToGlyphs_IsTypeOf_12(type);
		}

		// Token: 0x06014C30 RID: 85040
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToGlyphs_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C31 RID: 85041 RVA: 0x001D6148 File Offset: 0x001D4348
		public new vtkGraphToGlyphs NewInstance()
		{
			vtkGraphToGlyphs result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014C32 RID: 85042
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToGlyphs_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C33 RID: 85043 RVA: 0x001D61A4 File Offset: 0x001D43A4
		public new static vtkGraphToGlyphs SafeDownCast(vtkObjectBase o)
		{
			vtkGraphToGlyphs vtkGraphToGlyphs = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToGlyphs.vtkGraphToGlyphs_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphToGlyphs = (vtkGraphToGlyphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphToGlyphs.Register(null);
				}
			}
			return vtkGraphToGlyphs;
		}

		// Token: 0x06014C34 RID: 85044
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_SetFilled_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to fill the glyph, or to just render the outline.
		/// </summary>
		// Token: 0x06014C35 RID: 85045 RVA: 0x001D6223 File Offset: 0x001D4423
		public virtual void SetFilled(bool _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetFilled_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014C36 RID: 85046
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_SetGlyphType_17(HandleRef pThis, int _arg);

		/// <summary>
		/// The glyph type, specified as one of the enumerated values in this
		/// class. VERTEX is a special glyph that cannot be scaled, but instead
		/// is rendered as an OpenGL vertex primitive. This may appear as a box
		/// or circle depending on the hardware.
		/// </summary>
		// Token: 0x06014C37 RID: 85047 RVA: 0x001D623B File Offset: 0x001D443B
		public virtual void SetGlyphType(int _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetGlyphType_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06014C38 RID: 85048
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_SetRenderer_18(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// The renderer in which the glyphs will be placed.
		/// </summary>
		// Token: 0x06014C39 RID: 85049 RVA: 0x001D624C File Offset: 0x001D444C
		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetRenderer_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014C3A RID: 85050
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_SetScaling_19(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to use the input array to process in order to scale the
		/// vertices.
		/// </summary>
		// Token: 0x06014C3B RID: 85051 RVA: 0x001D627B File Offset: 0x001D447B
		public virtual void SetScaling(bool b)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetScaling_19(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06014C3C RID: 85052
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToGlyphs_SetScreenSize_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the desired screen size of each glyph. If you are using scaling,
		/// this will be the size of the glyph when rendering an object with
		/// scaling value 1.0.
		/// </summary>
		// Token: 0x06014C3D RID: 85053 RVA: 0x001D6293 File Offset: 0x001D4493
		public virtual void SetScreenSize(double _arg)
		{
			vtkGraphToGlyphs.vtkGraphToGlyphs_SetScreenSize_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017F3 RID: 6131
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToGlyphs";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017F4 RID: 6132
		public new static readonly string MRClassNameKey = "class vtkGraphToGlyphs";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020007E4 RID: 2020
		public enum CIRCLE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040017F6 RID: 6134
			CIRCLE = 7,
			/// <summary>enum member</summary>
			// Token: 0x040017F7 RID: 6135
			CROSS = 3,
			/// <summary>enum member</summary>
			// Token: 0x040017F8 RID: 6136
			DASH = 2,
			/// <summary>enum member</summary>
			// Token: 0x040017F9 RID: 6137
			DIAMOND = 8,
			/// <summary>enum member</summary>
			// Token: 0x040017FA RID: 6138
			SPHERE,
			/// <summary>enum member</summary>
			// Token: 0x040017FB RID: 6139
			SQUARE = 6,
			/// <summary>enum member</summary>
			// Token: 0x040017FC RID: 6140
			THICKCROSS = 4,
			/// <summary>enum member</summary>
			// Token: 0x040017FD RID: 6141
			TRIANGLE,
			/// <summary>enum member</summary>
			// Token: 0x040017FE RID: 6142
			VERTEX = 1
		}
	}
}
