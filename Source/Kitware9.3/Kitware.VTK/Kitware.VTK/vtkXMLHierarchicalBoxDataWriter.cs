using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLHierarchicalBoxDataWriter
	/// </summary>
	/// <remarks>
	///    writer for vtkHierarchicalBoxDataSet
	/// for backwards compatibility.
	///
	/// vtkXMLHierarchicalBoxDataWriter is an empty subclass of
	/// vtkXMLUniformGridAMRWriter for writing vtkUniformGridAMR datasets in
	/// VTK-XML format.
	/// </remarks>
	// Token: 0x020006CB RID: 1739
	public class vtkXMLHierarchicalBoxDataWriter : vtkXMLUniformGridAMRWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060127EF RID: 75759 RVA: 0x0019EDF3 File Offset: 0x0019CFF3
		static vtkXMLHierarchicalBoxDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLHierarchicalBoxDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLHierarchicalBoxDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060127F0 RID: 75760 RVA: 0x0019EE1B File Offset: 0x0019D01B
		public vtkXMLHierarchicalBoxDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060127F1 RID: 75761
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127F2 RID: 75762 RVA: 0x0019EE2C File Offset: 0x0019D02C
		public new static vtkXMLHierarchicalBoxDataWriter New()
		{
			vtkXMLHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127F3 RID: 75763 RVA: 0x0019EE80 File Offset: 0x0019D080
		public vtkXMLHierarchicalBoxDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060127F4 RID: 75764 RVA: 0x0019EEC4 File Offset: 0x0019D0C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060127F5 RID: 75765
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x060127F6 RID: 75766 RVA: 0x0019EED0 File Offset: 0x0019D0D0
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060127F7 RID: 75767
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127F8 RID: 75768 RVA: 0x0019EF0C File Offset: 0x0019D10C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060127F9 RID: 75769
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127FA RID: 75770 RVA: 0x0019EF2C File Offset: 0x0019D12C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060127FB RID: 75771
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127FC RID: 75772 RVA: 0x0019EF48 File Offset: 0x0019D148
		public override int IsA(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060127FD RID: 75773
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLHierarchicalBoxDataWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060127FE RID: 75774 RVA: 0x0019EF68 File Offset: 0x0019D168
		public new static int IsTypeOf(string type)
		{
			return vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_IsTypeOf_05(type);
		}

		// Token: 0x060127FF RID: 75775
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012800 RID: 75776 RVA: 0x0019EF84 File Offset: 0x0019D184
		public new vtkXMLHierarchicalBoxDataWriter NewInstance()
		{
			vtkXMLHierarchicalBoxDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012801 RID: 75777
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLHierarchicalBoxDataWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012802 RID: 75778 RVA: 0x0019EFE0 File Offset: 0x0019D1E0
		public new static vtkXMLHierarchicalBoxDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLHierarchicalBoxDataWriter vtkXMLHierarchicalBoxDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLHierarchicalBoxDataWriter.vtkXMLHierarchicalBoxDataWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLHierarchicalBoxDataWriter = (vtkXMLHierarchicalBoxDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLHierarchicalBoxDataWriter.Register(null);
				}
			}
			return vtkXMLHierarchicalBoxDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001547 RID: 5447
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLHierarchicalBoxDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001548 RID: 5448
		public new static readonly string MRClassNameKey = "class vtkXMLHierarchicalBoxDataWriter";
	}
}
