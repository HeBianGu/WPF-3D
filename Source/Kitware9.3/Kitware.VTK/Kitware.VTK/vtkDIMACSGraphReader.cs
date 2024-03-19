using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDIMACSGraphReader
	/// </summary>
	/// <remarks>
	///    reads vtkGraph data from a DIMACS
	/// formatted file
	///
	///
	/// vtkDIMACSGraphReader is a source object that reads vtkGraph data files
	/// from a DIMACS format.
	///
	/// The reader has special handlers for max-flow and graph coloring problems,
	/// which are specified in the problem line as 'max' and 'edge' respectively.
	/// Other graphs are treated as generic DIMACS files.
	///
	/// DIMACS formatted files consist of lines in which the first character in
	/// in column 0 specifies the type of the line.
	///
	/// Generic DIMACS files have the following line types:
	/// - problem statement line : p graph num_verts num_edges
	/// - node line (optional)   : n node_id node_weight
	/// - edge line              : a src_id trg_id edge_weight
	/// - alternate edge format  : e src_id trg_id edge_weight
	/// - comment lines          : c I am a comment line
	/// ** note, there should be one and only one problem statement line per file.
	///
	///
	/// DIMACS graphs are undirected and nodes are numbered 1..n
	///
	/// See webpage for additional formatting details.
	/// -  http://dimacs.rutgers.edu/Challenges/
	/// -  http://www.dis.uniroma1.it/~challenge9/format.shtml
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDIMACSGraphWriter
	///
	/// </seealso>
	// Token: 0x0200019A RID: 410
	public class vtkDIMACSGraphReader : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005075 RID: 20597 RVA: 0x00074CF4 File Offset: 0x00072EF4
		static vtkDIMACSGraphReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDIMACSGraphReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDIMACSGraphReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005076 RID: 20598 RVA: 0x00074D1C File Offset: 0x00072F1C
		public vtkDIMACSGraphReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005077 RID: 20599
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005078 RID: 20600 RVA: 0x00074D2C File Offset: 0x00072F2C
		public new static vtkDIMACSGraphReader New()
		{
			vtkDIMACSGraphReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005079 RID: 20601 RVA: 0x00074D80 File Offset: 0x00072F80
		public vtkDIMACSGraphReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDIMACSGraphReader.vtkDIMACSGraphReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600507A RID: 20602 RVA: 0x00074DC4 File Offset: 0x00072FC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600507B RID: 20603
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(HandleRef pThis);

		/// <summary>
		/// Edge attribute array name
		/// </summary>
		// Token: 0x0600507C RID: 20604 RVA: 0x00074DD0 File Offset: 0x00072FD0
		public virtual string GetEdgeAttributeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetEdgeAttributeArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600507D RID: 20605
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// The DIMACS file name.
		/// </summary>
		// Token: 0x0600507E RID: 20606 RVA: 0x00074E0C File Offset: 0x0007300C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600507F RID: 20607
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDIMACSGraphReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005080 RID: 20608 RVA: 0x00074E48 File Offset: 0x00073048
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06005081 RID: 20609
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDIMACSGraphReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005082 RID: 20610 RVA: 0x00074E68 File Offset: 0x00073068
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06005083 RID: 20611
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_GetVertexAttributeArrayName_05(HandleRef pThis);

		/// <summary>
		/// Vertex attribute array name
		/// </summary>
		// Token: 0x06005084 RID: 20612 RVA: 0x00074E84 File Offset: 0x00073084
		public virtual string GetVertexAttributeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDIMACSGraphReader.vtkDIMACSGraphReader_GetVertexAttributeArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005085 RID: 20613
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDIMACSGraphReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005086 RID: 20614 RVA: 0x00074EC0 File Offset: 0x000730C0
		public override int IsA(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06005087 RID: 20615
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDIMACSGraphReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005088 RID: 20616 RVA: 0x00074EE0 File Offset: 0x000730E0
		public new static int IsTypeOf(string type)
		{
			return vtkDIMACSGraphReader.vtkDIMACSGraphReader_IsTypeOf_07(type);
		}

		// Token: 0x06005089 RID: 20617
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600508A RID: 20618 RVA: 0x00074EFC File Offset: 0x000730FC
		public new vtkDIMACSGraphReader NewInstance()
		{
			vtkDIMACSGraphReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600508B RID: 20619
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600508C RID: 20620 RVA: 0x00074F58 File Offset: 0x00073158
		public new static vtkDIMACSGraphReader SafeDownCast(vtkObjectBase o)
		{
			vtkDIMACSGraphReader vtkDIMACSGraphReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphReader.vtkDIMACSGraphReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDIMACSGraphReader = (vtkDIMACSGraphReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDIMACSGraphReader.Register(null);
				}
			}
			return vtkDIMACSGraphReader;
		}

		// Token: 0x0600508D RID: 20621
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDIMACSGraphReader_SetEdgeAttributeArrayName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Edge attribute array name
		/// </summary>
		// Token: 0x0600508E RID: 20622 RVA: 0x00074FD7 File Offset: 0x000731D7
		public virtual void SetEdgeAttributeArrayName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetEdgeAttributeArrayName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600508F RID: 20623
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDIMACSGraphReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The DIMACS file name.
		/// </summary>
		// Token: 0x06005090 RID: 20624 RVA: 0x00074FE7 File Offset: 0x000731E7
		public virtual void SetFileName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06005091 RID: 20625
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDIMACSGraphReader_SetVertexAttributeArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Vertex attribute array name
		/// </summary>
		// Token: 0x06005092 RID: 20626 RVA: 0x00074FF7 File Offset: 0x000731F7
		public virtual void SetVertexAttributeArrayName(string _arg)
		{
			vtkDIMACSGraphReader.vtkDIMACSGraphReader_SetVertexAttributeArrayName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000797 RID: 1943
		public new const string MRFullTypeName = "Kitware.VTK.vtkDIMACSGraphReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000798 RID: 1944
		public new static readonly string MRClassNameKey = "class vtkDIMACSGraphReader";
	}
}
