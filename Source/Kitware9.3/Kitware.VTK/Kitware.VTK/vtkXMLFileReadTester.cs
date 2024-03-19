using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLFileReadTester
	/// </summary>
	/// <remarks>
	///    Utility class for vtkXMLReader and subclasses.
	///
	/// vtkXMLFileReadTester reads the smallest part of a file necessary to
	/// determine whether it is a VTK XML file.  If so, it extracts the
	/// file type and version number.
	/// </remarks>
	// Token: 0x020006C7 RID: 1735
	public class vtkXMLFileReadTester : vtkXMLParser
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012793 RID: 75667 RVA: 0x0019E3AB File Offset: 0x0019C5AB
		static vtkXMLFileReadTester()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLFileReadTester.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLFileReadTester"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012794 RID: 75668 RVA: 0x0019E3D3 File Offset: 0x0019C5D3
		public vtkXMLFileReadTester(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012795 RID: 75669
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileReadTester_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012796 RID: 75670 RVA: 0x0019E3E4 File Offset: 0x0019C5E4
		public new static vtkXMLFileReadTester New()
		{
			vtkXMLFileReadTester result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012797 RID: 75671 RVA: 0x0019E438 File Offset: 0x0019C638
		public vtkXMLFileReadTester() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLFileReadTester.vtkXMLFileReadTester_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012798 RID: 75672 RVA: 0x0019E47C File Offset: 0x0019C67C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012799 RID: 75673
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileReadTester_GetFileDataType_01(HandleRef pThis);

		/// <summary>
		/// Get the data type of the XML file tested.  If the file could not
		/// be read, returns nullptr.
		/// </summary>
		// Token: 0x0601279A RID: 75674 RVA: 0x0019E488 File Offset: 0x0019C688
		public virtual string GetFileDataType()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLFileReadTester.vtkXMLFileReadTester_GetFileDataType_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601279B RID: 75675
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileReadTester_GetFileVersion_02(HandleRef pThis);

		/// <summary>
		/// Get the file version of the XML file tested.  If the file could not
		/// be read, returns nullptr.
		/// </summary>
		// Token: 0x0601279C RID: 75676 RVA: 0x0019E4C4 File Offset: 0x0019C6C4
		public virtual string GetFileVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLFileReadTester.vtkXMLFileReadTester_GetFileVersion_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601279D RID: 75677
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLFileReadTester_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601279E RID: 75678 RVA: 0x0019E500 File Offset: 0x0019C700
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601279F RID: 75679
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLFileReadTester_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127A0 RID: 75680 RVA: 0x0019E520 File Offset: 0x0019C720
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060127A1 RID: 75681
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLFileReadTester_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127A2 RID: 75682 RVA: 0x0019E53C File Offset: 0x0019C73C
		public override int IsA(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060127A3 RID: 75683
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLFileReadTester_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127A4 RID: 75684 RVA: 0x0019E55C File Offset: 0x0019C75C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_IsTypeOf_06(type);
		}

		// Token: 0x060127A5 RID: 75685
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileReadTester_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127A6 RID: 75686 RVA: 0x0019E578 File Offset: 0x0019C778
		public new vtkXMLFileReadTester NewInstance()
		{
			vtkXMLFileReadTester result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060127A7 RID: 75687
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLFileReadTester_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127A8 RID: 75688 RVA: 0x0019E5D4 File Offset: 0x0019C7D4
		public new static vtkXMLFileReadTester SafeDownCast(vtkObjectBase o)
		{
			vtkXMLFileReadTester vtkXMLFileReadTester = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLFileReadTester.vtkXMLFileReadTester_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLFileReadTester = (vtkXMLFileReadTester)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLFileReadTester.Register(null);
				}
			}
			return vtkXMLFileReadTester;
		}

		// Token: 0x060127A9 RID: 75689
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLFileReadTester_TestReadFile_10(HandleRef pThis);

		/// <summary>
		/// Try to read the file given by FileName.  Returns 1 if the file is
		/// a VTK XML file, and 0 otherwise.
		/// </summary>
		// Token: 0x060127AA RID: 75690 RVA: 0x0019E654 File Offset: 0x0019C854
		public int TestReadFile()
		{
			return vtkXMLFileReadTester.vtkXMLFileReadTester_TestReadFile_10(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153F RID: 5439
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLFileReadTester";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001540 RID: 5440
		public new static readonly string MRClassNameKey = "class vtkXMLFileReadTester";
	}
}
