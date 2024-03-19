using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelSizeCalculator
	///
	/// This filter takes an input dataset, an array to process
	/// (which must be a string array), and a text property.
	/// It creates a new output array (named "LabelSize" by default) with
	/// 4 components per tuple that contain the width, height, horizontal
	/// offset, and descender height (in that order) of each string in
	/// the array.
	///
	/// Use the inherited SelectInputArrayToProcess to indicate a string array.
	/// In no input array is specified, the first of the following that
	/// is a string array is used: point scalars, cell scalars, field scalars.
	///
	/// The second input array to process is an array specifying the type of
	/// each label. Different label types may have different font properties.
	/// This array must be a vtkIntArray.
	/// Any type that does not map to a font property that was set will
	/// be set to the type 0's type property.
	/// </summary>
	// Token: 0x020000F7 RID: 247
	public class vtkLabelSizeCalculator : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060032CB RID: 13003 RVA: 0x0004AAF9 File Offset: 0x00048CF9
		static vtkLabelSizeCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelSizeCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelSizeCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060032CC RID: 13004 RVA: 0x0004AB21 File Offset: 0x00048D21
		public vtkLabelSizeCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060032CD RID: 13005
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelSizeCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032CE RID: 13006 RVA: 0x0004AB30 File Offset: 0x00048D30
		public new static vtkLabelSizeCalculator New()
		{
			vtkLabelSizeCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032CF RID: 13007 RVA: 0x0004AB84 File Offset: 0x00048D84
		public vtkLabelSizeCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelSizeCalculator.vtkLabelSizeCalculator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060032D0 RID: 13008 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060032D1 RID: 13009
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelSizeCalculator_GetDPI_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the DPI at which the labels are to be rendered. Defaults to 72.
		/// @sa vtkWindow::GetDPI()
		/// </summary>
		// Token: 0x060032D2 RID: 13010 RVA: 0x0004ABD4 File Offset: 0x00048DD4
		public virtual int GetDPI()
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetDPI_01(base.GetCppThis());
		}

		// Token: 0x060032D3 RID: 13011
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelSizeCalculator_GetFontProperty_02(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the font used compute label sizes.
		/// This defaults to "Arial" at 12 points.
		/// If type is provided, it refers to the type of the text label provided
		/// in the optional label type array. The default type is type 0.
		/// </summary>
		// Token: 0x060032D4 RID: 13012 RVA: 0x0004ABF4 File Offset: 0x00048DF4
		public virtual vtkTextProperty GetFontProperty(int type)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetFontProperty_02(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060032D5 RID: 13013
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelSizeCalculator_GetLabelSizeArrayName_03(HandleRef pThis);

		/// <summary>
		/// The name of the output array containing text label sizes
		/// This defaults to "LabelSize"
		/// </summary>
		// Token: 0x060032D6 RID: 13014 RVA: 0x0004AC64 File Offset: 0x00048E64
		public virtual string GetLabelSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetLabelSizeArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060032D7 RID: 13015
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelSizeCalculator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032D8 RID: 13016 RVA: 0x0004ACA0 File Offset: 0x00048EA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060032D9 RID: 13017
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelSizeCalculator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032DA RID: 13018 RVA: 0x0004ACC0 File Offset: 0x00048EC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060032DB RID: 13019
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelSizeCalculator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032DC RID: 13020 RVA: 0x0004ACDC File Offset: 0x00048EDC
		public override int IsA(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060032DD RID: 13021
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelSizeCalculator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032DE RID: 13022 RVA: 0x0004ACFC File Offset: 0x00048EFC
		public new static int IsTypeOf(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_IsTypeOf_07(type);
		}

		// Token: 0x060032DF RID: 13023
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelSizeCalculator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032E0 RID: 13024 RVA: 0x0004AD18 File Offset: 0x00048F18
		public new vtkLabelSizeCalculator NewInstance()
		{
			vtkLabelSizeCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060032E1 RID: 13025
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelSizeCalculator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060032E2 RID: 13026 RVA: 0x0004AD74 File Offset: 0x00048F74
		public new static vtkLabelSizeCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelSizeCalculator vtkLabelSizeCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelSizeCalculator = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelSizeCalculator.Register(null);
				}
			}
			return vtkLabelSizeCalculator;
		}

		// Token: 0x060032E3 RID: 13027
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelSizeCalculator_SetDPI_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the DPI at which the labels are to be rendered. Defaults to 72.
		/// @sa vtkWindow::GetDPI()
		/// </summary>
		// Token: 0x060032E4 RID: 13028 RVA: 0x0004ADF3 File Offset: 0x00048FF3
		public virtual void SetDPI(int _arg)
		{
			vtkLabelSizeCalculator.vtkLabelSizeCalculator_SetDPI_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060032E5 RID: 13029
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelSizeCalculator_SetFontProperty_12(HandleRef pThis, HandleRef fontProp, int type);

		/// <summary>
		/// Get/Set the font used compute label sizes.
		/// This defaults to "Arial" at 12 points.
		/// If type is provided, it refers to the type of the text label provided
		/// in the optional label type array. The default type is type 0.
		/// </summary>
		// Token: 0x060032E6 RID: 13030 RVA: 0x0004AE04 File Offset: 0x00049004
		public virtual void SetFontProperty(vtkTextProperty fontProp, int type)
		{
			vtkLabelSizeCalculator.vtkLabelSizeCalculator_SetFontProperty_12(base.GetCppThis(), (fontProp == null) ? default(HandleRef) : fontProp.GetCppThis(), type);
		}

		// Token: 0x060032E7 RID: 13031
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelSizeCalculator_SetLabelSizeArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the output array containing text label sizes
		/// This defaults to "LabelSize"
		/// </summary>
		// Token: 0x060032E8 RID: 13032 RVA: 0x0004AE34 File Offset: 0x00049034
		public virtual void SetLabelSizeArrayName(string _arg)
		{
			vtkLabelSizeCalculator.vtkLabelSizeCalculator_SetLabelSizeArrayName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000612 RID: 1554
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelSizeCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000613 RID: 1555
		public new static readonly string MRClassNameKey = "class vtkLabelSizeCalculator";
	}
}
