using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLHierarchicalBoxDataFileConverter
	/// </summary>
	/// <remarks>
	///    converts older *.vth, *.vthb
	/// files to newer format.
	///
	/// vtkXMLHierarchicalBoxDataFileConverter is a utility class to convert v0.1 and
	/// v1.0 of the VTK XML hierarchical file format to the v1.1. Users can then use
	/// vtkXMLUniformGridAMRReader to read the dataset into VTK.
	/// </remarks>
	// Token: 0x020006C8 RID: 1736
	public class vtkXMLHierarchicalBoxDataFileConverter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060127AB RID: 75691 RVA: 0x0019E673 File Offset: 0x0019C873
		static vtkXMLHierarchicalBoxDataFileConverter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalBoxDataFileConverter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataFileConverter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060127AC RID: 75692 RVA: 0x0019E69B File Offset: 0x0019C89B
		public vtkXMLHierarchicalBoxDataFileConverter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060127AD RID: 75693
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127AE RID: 75694 RVA: 0x0019E6AC File Offset: 0x0019C8AC
		public new static vtkXMLHierarchicalBoxDataFileConverter New()
		{
			vtkXMLHierarchicalBoxDataFileConverter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127AF RID: 75695 RVA: 0x0019E700 File Offset: 0x0019C900
		public vtkXMLHierarchicalBoxDataFileConverter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060127B0 RID: 75696 RVA: 0x0019E744 File Offset: 0x0019C944
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060127B1 RID: 75697
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLHierarchicalBoxDataFileConverter_Convert_01(HandleRef pThis);

		/// <summary>
		/// Converts the input file to new format and writes out the output file.
		/// </summary>
		// Token: 0x060127B2 RID: 75698 RVA: 0x0019E750 File Offset: 0x0019C950
		public bool Convert()
		{
			return vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_Convert_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060127B3 RID: 75699
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_GetInputFileName_02(HandleRef pThis);

		/// <summary>
		/// Set the input filename.
		/// </summary>
		// Token: 0x060127B4 RID: 75700 RVA: 0x0019E778 File Offset: 0x0019C978
		public virtual string GetInputFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_GetInputFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060127B5 RID: 75701
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127B6 RID: 75702 RVA: 0x0019E7B4 File Offset: 0x0019C9B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060127B7 RID: 75703
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127B8 RID: 75704 RVA: 0x0019E7D4 File Offset: 0x0019C9D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060127B9 RID: 75705
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_GetOutputFileName_05(HandleRef pThis);

		/// <summary>
		/// Set the output filename.
		/// </summary>
		// Token: 0x060127BA RID: 75706 RVA: 0x0019E7F0 File Offset: 0x0019C9F0
		public virtual string GetOutputFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_GetOutputFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060127BB RID: 75707
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataFileConverter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127BC RID: 75708 RVA: 0x0019E82C File Offset: 0x0019CA2C
		public override int IsA(string type)
		{
			return vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060127BD RID: 75709
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataFileConverter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127BE RID: 75710 RVA: 0x0019E84C File Offset: 0x0019CA4C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_IsTypeOf_07(type);
		}

		// Token: 0x060127BF RID: 75711
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127C0 RID: 75712 RVA: 0x0019E868 File Offset: 0x0019CA68
		public new vtkXMLHierarchicalBoxDataFileConverter NewInstance()
		{
			vtkXMLHierarchicalBoxDataFileConverter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060127C1 RID: 75713
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataFileConverter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127C2 RID: 75714 RVA: 0x0019E8C4 File Offset: 0x0019CAC4
		public new static vtkXMLHierarchicalBoxDataFileConverter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalBoxDataFileConverter vtkXMLHierarchicalBoxDataFileConverter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalBoxDataFileConverter = (vtkXMLHierarchicalBoxDataFileConverter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalBoxDataFileConverter.Register(null);
				}
			}
			return vtkXMLHierarchicalBoxDataFileConverter;
		}

		// Token: 0x060127C3 RID: 75715
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLHierarchicalBoxDataFileConverter_SetInputFileName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the input filename.
		/// </summary>
		// Token: 0x060127C4 RID: 75716 RVA: 0x0019E943 File Offset: 0x0019CB43
		public virtual void SetInputFileName(string _arg)
		{
			vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_SetInputFileName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060127C5 RID: 75717
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLHierarchicalBoxDataFileConverter_SetOutputFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the output filename.
		/// </summary>
		// Token: 0x060127C6 RID: 75718 RVA: 0x0019E953 File Offset: 0x0019CB53
		public virtual void SetOutputFileName(string _arg)
		{
			vtkXMLHierarchicalBoxDataFileConverter.vtkXMLHierarchicalBoxDataFileConverter_SetOutputFileName_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001541 RID: 5441
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataFileConverter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001542 RID: 5442
		public new static readonly string MRClassNameKey = "class vtkXMLHierarchicalBoxDataFileConverter";
	}
}
