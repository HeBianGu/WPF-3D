using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVectorText
	/// </summary>
	/// <remarks>
	///    create polygonal text
	///
	///
	/// vtkVectorText generates vtkPolyData from an input text string. Besides the
	/// ASCII alphanumeric characters a-z, A-Z, 0-9, vtkVectorText also supports
	/// ASCII punctuation marks. (The supported ASCII character set are the codes
	/// (33-126) inclusive.) The only control character supported is the line feed
	/// character "\n", which advances to a new line.
	///
	/// To use this class, you normally couple it with a vtkPolyDataMapper and a
	/// vtkActor. In this case you would use the vtkActor's transformation methods
	/// to position, orient, and scale the text. You may also wish to use a
	/// vtkFollower to orient the text so that it always faces the camera.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextMapper vtkCaptionActor2D
	/// </seealso>
	// Token: 0x020007C3 RID: 1987
	public class vtkVectorText : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060145BE RID: 83390 RVA: 0x001CCBFF File Offset: 0x001CADFF
		static vtkVectorText()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorText.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorText"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060145BF RID: 83391 RVA: 0x001CCC27 File Offset: 0x001CAE27
		public vtkVectorText(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060145C0 RID: 83392
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorText_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145C1 RID: 83393 RVA: 0x001CCC38 File Offset: 0x001CAE38
		public new static vtkVectorText New()
		{
			vtkVectorText result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorText.vtkVectorText_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145C2 RID: 83394 RVA: 0x001CCC8C File Offset: 0x001CAE8C
		public vtkVectorText() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVectorText.vtkVectorText_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060145C3 RID: 83395 RVA: 0x001CCCD0 File Offset: 0x001CAED0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060145C4 RID: 83396
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorText_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145C5 RID: 83397 RVA: 0x001CCCDC File Offset: 0x001CAEDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVectorText.vtkVectorText_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060145C6 RID: 83398
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorText_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145C7 RID: 83399 RVA: 0x001CCCFC File Offset: 0x001CAEFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVectorText.vtkVectorText_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060145C8 RID: 83400
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorText_GetText_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the text to be drawn.
		/// </summary>
		// Token: 0x060145C9 RID: 83401 RVA: 0x001CCD18 File Offset: 0x001CAF18
		public virtual string GetText()
		{
			string s = Marshal.PtrToStringAnsi(vtkVectorText.vtkVectorText_GetText_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060145CA RID: 83402
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorText_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145CB RID: 83403 RVA: 0x001CCD54 File Offset: 0x001CAF54
		public override int IsA(string type)
		{
			return vtkVectorText.vtkVectorText_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060145CC RID: 83404
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorText_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145CD RID: 83405 RVA: 0x001CCD74 File Offset: 0x001CAF74
		public new static int IsTypeOf(string type)
		{
			return vtkVectorText.vtkVectorText_IsTypeOf_05(type);
		}

		// Token: 0x060145CE RID: 83406
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorText_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145CF RID: 83407 RVA: 0x001CCD90 File Offset: 0x001CAF90
		public new vtkVectorText NewInstance()
		{
			vtkVectorText result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorText.vtkVectorText_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060145D0 RID: 83408
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorText_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060145D1 RID: 83409 RVA: 0x001CCDEC File Offset: 0x001CAFEC
		public new static vtkVectorText SafeDownCast(vtkObjectBase o)
		{
			vtkVectorText vtkVectorText = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorText.vtkVectorText_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorText = (vtkVectorText)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorText.Register(null);
				}
			}
			return vtkVectorText;
		}

		// Token: 0x060145D2 RID: 83410
		[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorText_SetText_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the text to be drawn.
		/// </summary>
		// Token: 0x060145D3 RID: 83411 RVA: 0x001CCE6B File Offset: 0x001CB06B
		public virtual void SetText(string _arg)
		{
			vtkVectorText.vtkVectorText_SetText_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A4 RID: 6052
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorText";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017A5 RID: 6053
		public new static readonly string MRClassNameKey = "class vtkVectorText";
	}
}
