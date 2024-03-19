using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExodusIIReaderParser
	/// </summary>
	/// <remarks>
	///    internal parser used by vtkExodusIIReader.
	///
	/// vtkExodusIIReaderParser is an internal XML parser used by vtkExodusIIReader.
	/// This is not for public use.
	/// </remarks>
	// Token: 0x020001BB RID: 443
	public class vtkExodusIIReaderParser : vtkXMLParser
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005686 RID: 22150 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		static vtkExodusIIReaderParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIIReaderParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIReaderParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005687 RID: 22151 RVA: 0x0007D3F4 File Offset: 0x0007B5F4
		public vtkExodusIIReaderParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005688 RID: 22152
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReaderParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005689 RID: 22153 RVA: 0x0007D404 File Offset: 0x0007B604
		public new static vtkExodusIIReaderParser New()
		{
			vtkExodusIIReaderParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReaderParser.vtkExodusIIReaderParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600568A RID: 22154 RVA: 0x0007D458 File Offset: 0x0007B658
		public vtkExodusIIReaderParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExodusIIReaderParser.vtkExodusIIReaderParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600568B RID: 22155 RVA: 0x0007D49C File Offset: 0x0007B69C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600568C RID: 22156
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkExodusIIReaderParser_GetBlockName_01(HandleRef pThis, int id);

		/// <summary>
		/// Given a block "id" return the name as determined from the xml.
		/// This is valid only after Go().
		/// </summary>
		// Token: 0x0600568D RID: 22157 RVA: 0x0007D4A8 File Offset: 0x0007B6A8
		public string GetBlockName(int id)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_GetBlockName_01(base.GetCppThis(), id);
		}

		// Token: 0x0600568E RID: 22158
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReaderParser_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600568F RID: 22159 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005690 RID: 22160
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIIReaderParser_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005691 RID: 22161 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005692 RID: 22162
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReaderParser_GetSIL_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the SIL.
		/// This is valid only after Go().
		/// </summary>
		// Token: 0x06005693 RID: 22163 RVA: 0x0007D504 File Offset: 0x0007B704
		public virtual vtkMutableDirectedGraph GetSIL()
		{
			vtkMutableDirectedGraph vtkMutableDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReaderParser.vtkExodusIIReaderParser_GetSIL_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableDirectedGraph = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableDirectedGraph.Register(null);
				}
			}
			return vtkMutableDirectedGraph;
		}

		// Token: 0x06005694 RID: 22164
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIIReaderParser_Go_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Trigger parsing of the XML file.
		/// </summary>
		// Token: 0x06005695 RID: 22165 RVA: 0x0007D573 File Offset: 0x0007B773
		public void Go(string filename)
		{
			vtkExodusIIReaderParser.vtkExodusIIReaderParser_Go_05(base.GetCppThis(), filename);
		}

		// Token: 0x06005696 RID: 22166
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExodusIIReaderParser_HasInformationAboutBlock_06(HandleRef pThis, int id);

		/// <summary>
		/// Trigger parsing of the XML file.
		/// </summary>
		// Token: 0x06005697 RID: 22167 RVA: 0x0007D584 File Offset: 0x0007B784
		public bool HasInformationAboutBlock(int id)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_HasInformationAboutBlock_06(base.GetCppThis(), id) != 0;
		}

		// Token: 0x06005698 RID: 22168
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReaderParser_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005699 RID: 22169 RVA: 0x0007D5AC File Offset: 0x0007B7AC
		public override int IsA(string type)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600569A RID: 22170
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIIReaderParser_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600569B RID: 22171 RVA: 0x0007D5CC File Offset: 0x0007B7CC
		public new static int IsTypeOf(string type)
		{
			return vtkExodusIIReaderParser.vtkExodusIIReaderParser_IsTypeOf_08(type);
		}

		// Token: 0x0600569C RID: 22172
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReaderParser_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600569D RID: 22173 RVA: 0x0007D5E8 File Offset: 0x0007B7E8
		public new vtkExodusIIReaderParser NewInstance()
		{
			vtkExodusIIReaderParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReaderParser.vtkExodusIIReaderParser_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600569E RID: 22174
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIIReaderParser_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600569F RID: 22175 RVA: 0x0007D644 File Offset: 0x0007B844
		public new static vtkExodusIIReaderParser SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIIReaderParser vtkExodusIIReaderParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIIReaderParser.vtkExodusIIReaderParser_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIIReaderParser = (vtkExodusIIReaderParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIIReaderParser.Register(null);
				}
			}
			return vtkExodusIIReaderParser;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000817 RID: 2071
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIReaderParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000818 RID: 2072
		public new static readonly string MRClassNameKey = "class vtkExodusIIReaderParser";
	}
}
