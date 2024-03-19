using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWriter
	/// </summary>
	/// <remarks>
	///    abstract class to write data to file(s)
	///
	/// vtkWriter is an abstract class for mapper objects that write their data
	/// to disk (or into a communications port). All writers respond to Write()
	/// method. This method insures that there is input and input is up to date.
	///
	/// @warning
	/// Every subclass of vtkWriter must implement a WriteData() method. Most likely
	/// will have to create SetInput() method as well.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataSetWriter vtkDataSetWriter vtkImageWriter vtkMCubesWriter
	/// </seealso>
	// Token: 0x02000150 RID: 336
	public abstract class vtkWriter : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003FFF RID: 16383 RVA: 0x0005E0B3 File Offset: 0x0005C2B3
		static vtkWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004000 RID: 16384 RVA: 0x0005E0DB File Offset: 0x0005C2DB
		public vtkWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004001 RID: 16385 RVA: 0x0005E0E9 File Offset: 0x0005C2E9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004002 RID: 16386
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWriter_EncodeString_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string resname, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte doublePercent);

		/// <summary>
		/// Encode the string so that the reader will not have problems.
		/// The resulting string is up to three times the size of the input
		/// string.  doublePercent indicates whether to output a double '%' before
		/// escaped characters so the string may be used as a printf format string.
		/// </summary>
		// Token: 0x06004003 RID: 16387 RVA: 0x0005E0F4 File Offset: 0x0005C2F4
		public void EncodeString(string resname, string name, bool doublePercent)
		{
			vtkWriter.vtkWriter_EncodeString_01(base.GetCppThis(), resname, name, doublePercent ? (byte)1 : (byte)0);
		}

		// Token: 0x06004004 RID: 16388
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the input to this writer.
		/// </summary>
		// Token: 0x06004005 RID: 16389 RVA: 0x0005E110 File Offset: 0x0005C310
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWriter.vtkWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06004006 RID: 16390
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the input to this writer.
		/// </summary>
		// Token: 0x06004007 RID: 16391 RVA: 0x0005E180 File Offset: 0x0005C380
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWriter.vtkWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06004008 RID: 16392
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004009 RID: 16393 RVA: 0x0005E1F0 File Offset: 0x0005C3F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWriter.vtkWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600400A RID: 16394
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600400B RID: 16395 RVA: 0x0005E210 File Offset: 0x0005C410
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWriter.vtkWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600400C RID: 16396
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600400D RID: 16397 RVA: 0x0005E22C File Offset: 0x0005C42C
		public override int IsA(string type)
		{
			return vtkWriter.vtkWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600400E RID: 16398
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600400F RID: 16399 RVA: 0x0005E24C File Offset: 0x0005C44C
		public new static int IsTypeOf(string type)
		{
			return vtkWriter.vtkWriter_IsTypeOf_07(type);
		}

		// Token: 0x06004010 RID: 16400
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004011 RID: 16401 RVA: 0x0005E268 File Offset: 0x0005C468
		public new vtkWriter NewInstance()
		{
			vtkWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWriter.vtkWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004012 RID: 16402
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004013 RID: 16403 RVA: 0x0005E2C4 File Offset: 0x0005C4C4
		public new static vtkWriter SafeDownCast(vtkObjectBase o)
		{
			vtkWriter vtkWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWriter.vtkWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWriter = (vtkWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWriter.Register(null);
				}
			}
			return vtkWriter;
		}

		// Token: 0x06004014 RID: 16404
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWriter_SetInputData_10(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/get the input to this writer.
		/// </summary>
		// Token: 0x06004015 RID: 16405 RVA: 0x0005E344 File Offset: 0x0005C544
		public void SetInputData(vtkDataObject input)
		{
			vtkWriter.vtkWriter_SetInputData_10(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06004016 RID: 16406
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWriter_SetInputData_11(HandleRef pThis, int index, HandleRef input);

		/// <summary>
		/// Set/get the input to this writer.
		/// </summary>
		// Token: 0x06004017 RID: 16407 RVA: 0x0005E374 File Offset: 0x0005C574
		public void SetInputData(int index, vtkDataObject input)
		{
			vtkWriter.vtkWriter_SetInputData_11(base.GetCppThis(), index, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06004018 RID: 16408
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWriter_Write_12(HandleRef pThis);

		/// <summary>
		/// Write data to output. Method executes subclasses WriteData() method, as
		/// well as StartMethod() and EndMethod() methods.
		/// Returns 1 on success and 0 on failure.
		/// </summary>
		// Token: 0x06004019 RID: 16409 RVA: 0x0005E3A4 File Offset: 0x0005C5A4
		public virtual int Write()
		{
			return vtkWriter.vtkWriter_Write_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E4 RID: 1764
		public new const string MRFullTypeName = "Kitware.VTK.vtkWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006E5 RID: 1765
		public new static readonly string MRClassNameKey = "class vtkWriter";
	}
}
