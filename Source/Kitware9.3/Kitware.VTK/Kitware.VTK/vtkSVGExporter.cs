using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkSVGExporter
	/// </summary>
	/// <remarks>
	///  Exports vtkContext2D scenes to SVG.
	///
	/// This exporter draws context2D scenes into a SVG file.
	///
	/// Limitations:
	/// - The Nearest/Linear texture properties are ignored, since SVG doesn't
	///   provide any reliable control over interpolation.
	/// - Embedded fonts are experimental and poorly tested. Viewer support is
	///   lacking at the time of writing, hence the feature is largely useless. By
	///   default, fonts are not embedded since they're basically useless bloat.
	///   (this option is not exposed in vtkSVGExporter).
	/// - TextAsPath is enabled by default, since viewers differ wildly in how they
	///   handle text objects (eg. Inkscape renders at expected size, but webkit is
	///   way too big).
	/// - Pattern fills and markers are not shown on some viewers, e.g. KDE's okular
	///   (Webkit seems to work, though).
	/// - Clipping seems to be broken in most viewers. Webkit is buggy and forces the
	///   clip coordinates to objectBoundingBox, even when explicitly set to
	///   userSpaceOnUse.
	/// - Many viewers anti-alias the output, leaving thin outlines around the
	///   triangles that make up larger polygons. This is a viewer issue and there
	///   not much we can do about it from the VTK side of things (and most viewers
	///   don't seem to have an antialiasing toggle, either...).
	///
	/// If ActiveRenderer is specified then it exports contents of
	/// ActiveRenderer. Otherwise it exports contents of all renderers.
	/// </remarks>
	// Token: 0x020001F3 RID: 499
	public class vtkSVGExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006046 RID: 24646 RVA: 0x0008AA81 File Offset: 0x00088C81
		static vtkSVGExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSVGExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSVGExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006047 RID: 24647 RVA: 0x0008AAA9 File Offset: 0x00088CA9
		public vtkSVGExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006048 RID: 24648
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006049 RID: 24649 RVA: 0x0008AAB8 File Offset: 0x00088CB8
		public new static vtkSVGExporter New()
		{
			vtkSVGExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSVGExporter.vtkSVGExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600604A RID: 24650 RVA: 0x0008AB0C File Offset: 0x00088D0C
		public vtkSVGExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSVGExporter.vtkSVGExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600604B RID: 24651 RVA: 0x0008AB50 File Offset: 0x00088D50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600604C RID: 24652
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_DrawBackgroundOff_01(HandleRef pThis);

		/// <summary>
		/// If true, the background will be drawn into the output document. Default
		/// is true.
		/// @{
		/// </summary>
		// Token: 0x0600604D RID: 24653 RVA: 0x0008AB5B File Offset: 0x00088D5B
		public virtual void DrawBackgroundOff()
		{
			vtkSVGExporter.vtkSVGExporter_DrawBackgroundOff_01(base.GetCppThis());
		}

		// Token: 0x0600604E RID: 24654
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_DrawBackgroundOn_02(HandleRef pThis);

		/// <summary>
		/// If true, the background will be drawn into the output document. Default
		/// is true.
		/// @{
		/// </summary>
		// Token: 0x0600604F RID: 24655 RVA: 0x0008AB6A File Offset: 0x00088D6A
		public virtual void DrawBackgroundOn()
		{
			vtkSVGExporter.vtkSVGExporter_DrawBackgroundOn_02(base.GetCppThis());
		}

		// Token: 0x06006050 RID: 24656
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_GetDescription_03(HandleRef pThis);

		/// <summary>
		/// A description of the exported document. @{ 
		/// </summary>
		// Token: 0x06006051 RID: 24657 RVA: 0x0008AB7C File Offset: 0x00088D7C
		public virtual string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkSVGExporter.vtkSVGExporter_GetDescription_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006052 RID: 24658
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSVGExporter_GetDrawBackground_04(HandleRef pThis);

		/// <summary>
		/// If true, the background will be drawn into the output document. Default
		/// is true.
		/// @{
		/// </summary>
		// Token: 0x06006053 RID: 24659 RVA: 0x0008ABB8 File Offset: 0x00088DB8
		public virtual bool GetDrawBackground()
		{
			return vtkSVGExporter.vtkSVGExporter_GetDrawBackground_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06006054 RID: 24660
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// The name of the exported file. @{ 
		/// </summary>
		// Token: 0x06006055 RID: 24661 RVA: 0x0008ABE0 File Offset: 0x00088DE0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSVGExporter.vtkSVGExporter_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006056 RID: 24662
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSVGExporter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006057 RID: 24663 RVA: 0x0008AC1C File Offset: 0x00088E1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSVGExporter.vtkSVGExporter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06006058 RID: 24664
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSVGExporter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006059 RID: 24665 RVA: 0x0008AC3C File Offset: 0x00088E3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSVGExporter.vtkSVGExporter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600605A RID: 24666
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSVGExporter_GetSubdivisionThreshold_08(HandleRef pThis);

		/// <summary>
		/// Set the threshold for subdividing gradient-shaded polygons/line. Default
		/// value is 1, and lower values yield higher quality and larger files. Larger
		/// values will reduce the number of primitives, but will decrease quality.
		///
		/// A triangle / line will not be subdivided further if all of it's vertices
		/// satisfy the equation:
		///
		/// |v1 - v2|^2 &lt; thresh
		///
		/// e.g. the squared norm of the vector between any verts must be greater than
		/// the threshold for subdivision to occur.
		///
		/// @{
		/// </summary>
		// Token: 0x0600605B RID: 24667 RVA: 0x0008AC58 File Offset: 0x00088E58
		public virtual float GetSubdivisionThreshold()
		{
			return vtkSVGExporter.vtkSVGExporter_GetSubdivisionThreshold_08(base.GetCppThis());
		}

		// Token: 0x0600605C RID: 24668
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSVGExporter_GetTextAsPath_09(HandleRef pThis);

		/// <summary>
		/// If true, draw all text as path objects rather than text objects. Enabling
		/// this option will:
		///
		/// - Improve portability (text will look exactly the same everywhere).
		/// - Increase file size (text objects are much more compact than paths).
		/// - Prevent text from being easily edited (text metadata is lost).
		///
		/// Note that some text (e.g. MathText) is always rendered as a path.
		///
		/// The default is true, as many browsers and SVG viewers render text
		/// inconsistently.
		///
		/// @{
		/// </summary>
		// Token: 0x0600605D RID: 24669 RVA: 0x0008AC78 File Offset: 0x00088E78
		public virtual bool GetTextAsPath()
		{
			return vtkSVGExporter.vtkSVGExporter_GetTextAsPath_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600605E RID: 24670
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_GetTitle_10(HandleRef pThis);

		/// <summary>
		/// The title of the exported document. @{ 
		/// </summary>
		// Token: 0x0600605F RID: 24671 RVA: 0x0008ACA0 File Offset: 0x00088EA0
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkSVGExporter.vtkSVGExporter_GetTitle_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006060 RID: 24672
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSVGExporter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006061 RID: 24673 RVA: 0x0008ACDC File Offset: 0x00088EDC
		public override int IsA(string type)
		{
			return vtkSVGExporter.vtkSVGExporter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06006062 RID: 24674
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSVGExporter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006063 RID: 24675 RVA: 0x0008ACFC File Offset: 0x00088EFC
		public new static int IsTypeOf(string type)
		{
			return vtkSVGExporter.vtkSVGExporter_IsTypeOf_12(type);
		}

		// Token: 0x06006064 RID: 24676
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006065 RID: 24677 RVA: 0x0008AD18 File Offset: 0x00088F18
		public new vtkSVGExporter NewInstance()
		{
			vtkSVGExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSVGExporter.vtkSVGExporter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006066 RID: 24678
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSVGExporter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006067 RID: 24679 RVA: 0x0008AD74 File Offset: 0x00088F74
		public new static vtkSVGExporter SafeDownCast(vtkObjectBase o)
		{
			vtkSVGExporter vtkSVGExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSVGExporter.vtkSVGExporter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSVGExporter = (vtkSVGExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSVGExporter.Register(null);
				}
			}
			return vtkSVGExporter;
		}

		// Token: 0x06006068 RID: 24680
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetDescription_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// A description of the exported document. @{ 
		/// </summary>
		// Token: 0x06006069 RID: 24681 RVA: 0x0008ADF3 File Offset: 0x00088FF3
		public virtual void SetDescription(string _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetDescription_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600606A RID: 24682
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetDrawBackground_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, the background will be drawn into the output document. Default
		/// is true.
		/// @{
		/// </summary>
		// Token: 0x0600606B RID: 24683 RVA: 0x0008AE03 File Offset: 0x00089003
		public virtual void SetDrawBackground(bool _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetDrawBackground_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600606C RID: 24684
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the exported file. @{ 
		/// </summary>
		// Token: 0x0600606D RID: 24685 RVA: 0x0008AE1B File Offset: 0x0008901B
		public virtual void SetFileName(string _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetFileName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600606E RID: 24686
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetSubdivisionThreshold_19(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the threshold for subdividing gradient-shaded polygons/line. Default
		/// value is 1, and lower values yield higher quality and larger files. Larger
		/// values will reduce the number of primitives, but will decrease quality.
		///
		/// A triangle / line will not be subdivided further if all of it's vertices
		/// satisfy the equation:
		///
		/// |v1 - v2|^2 &lt; thresh
		///
		/// e.g. the squared norm of the vector between any verts must be greater than
		/// the threshold for subdivision to occur.
		///
		/// @{
		/// </summary>
		// Token: 0x0600606F RID: 24687 RVA: 0x0008AE2B File Offset: 0x0008902B
		public virtual void SetSubdivisionThreshold(float _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetSubdivisionThreshold_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006070 RID: 24688
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetTextAsPath_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, draw all text as path objects rather than text objects. Enabling
		/// this option will:
		///
		/// - Improve portability (text will look exactly the same everywhere).
		/// - Increase file size (text objects are much more compact than paths).
		/// - Prevent text from being easily edited (text metadata is lost).
		///
		/// Note that some text (e.g. MathText) is always rendered as a path.
		///
		/// The default is true, as many browsers and SVG viewers render text
		/// inconsistently.
		///
		/// @{
		/// </summary>
		// Token: 0x06006071 RID: 24689 RVA: 0x0008AE3B File Offset: 0x0008903B
		public virtual void SetTextAsPath(bool _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetTextAsPath_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06006072 RID: 24690
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_SetTitle_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The title of the exported document. @{ 
		/// </summary>
		// Token: 0x06006073 RID: 24691 RVA: 0x0008AE53 File Offset: 0x00089053
		public virtual void SetTitle(string _arg)
		{
			vtkSVGExporter.vtkSVGExporter_SetTitle_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06006074 RID: 24692
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_TextAsPathOff_22(HandleRef pThis);

		/// <summary>
		/// If true, draw all text as path objects rather than text objects. Enabling
		/// this option will:
		///
		/// - Improve portability (text will look exactly the same everywhere).
		/// - Increase file size (text objects are much more compact than paths).
		/// - Prevent text from being easily edited (text metadata is lost).
		///
		/// Note that some text (e.g. MathText) is always rendered as a path.
		///
		/// The default is true, as many browsers and SVG viewers render text
		/// inconsistently.
		///
		/// @{
		/// </summary>
		// Token: 0x06006075 RID: 24693 RVA: 0x0008AE63 File Offset: 0x00089063
		public virtual void TextAsPathOff()
		{
			vtkSVGExporter.vtkSVGExporter_TextAsPathOff_22(base.GetCppThis());
		}

		// Token: 0x06006076 RID: 24694
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSVGExporter_TextAsPathOn_23(HandleRef pThis);

		/// <summary>
		/// If true, draw all text as path objects rather than text objects. Enabling
		/// this option will:
		///
		/// - Improve portability (text will look exactly the same everywhere).
		/// - Increase file size (text objects are much more compact than paths).
		/// - Prevent text from being easily edited (text metadata is lost).
		///
		/// Note that some text (e.g. MathText) is always rendered as a path.
		///
		/// The default is true, as many browsers and SVG viewers render text
		/// inconsistently.
		///
		/// @{
		/// </summary>
		// Token: 0x06006077 RID: 24695 RVA: 0x0008AE72 File Offset: 0x00089072
		public virtual void TextAsPathOn()
		{
			vtkSVGExporter.vtkSVGExporter_TextAsPathOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B0 RID: 2224
		public new const string MRFullTypeName = "Kitware.VTK.vtkSVGExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008B1 RID: 2225
		public new static readonly string MRClassNameKey = "class vtkSVGExporter";
	}
}
