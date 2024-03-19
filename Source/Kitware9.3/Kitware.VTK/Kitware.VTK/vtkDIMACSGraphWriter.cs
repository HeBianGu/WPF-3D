using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDIMACSGraphWriter
	/// </summary>
	/// <remarks>
	///    write vtkGraph data to a DIMACS
	/// formatted file
	///
	///
	/// vtkDIMACSGraphWriter is a sink object that writes
	/// vtkGraph data files into a generic DIMACS (.gr) format.
	///
	/// Output files contain a problem statement line:
	///
	/// p graph \em num_verts \em num_edges
	///
	/// Followed by |E| edge descriptor lines that are formatted as:
	///
	/// e \em source \em target \em weight
	///
	/// Vertices are numbered from 1..n in DIMACS formatted files.
	///
	/// See webpage for format details.
	/// http://prolland.free.fr/works/research/dsat/dimacs.html
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDIMACSGraphReader
	///
	/// </seealso>
	// Token: 0x0200019B RID: 411
	public class vtkDIMACSGraphWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005093 RID: 20627 RVA: 0x00075007 File Offset: 0x00073207
		static vtkDIMACSGraphWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDIMACSGraphWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDIMACSGraphWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005094 RID: 20628 RVA: 0x0007502F File Offset: 0x0007322F
		public vtkDIMACSGraphWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005095 RID: 20629
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005096 RID: 20630 RVA: 0x00075040 File Offset: 0x00073240
		public new static vtkDIMACSGraphWriter New()
		{
			vtkDIMACSGraphWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005097 RID: 20631 RVA: 0x00075094 File Offset: 0x00073294
		public vtkDIMACSGraphWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005098 RID: 20632 RVA: 0x000750D8 File Offset: 0x000732D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005099 RID: 20633
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0600509A RID: 20634 RVA: 0x000750E4 File Offset: 0x000732E4
		public new vtkGraph GetInput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0600509B RID: 20635
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0600509C RID: 20636 RVA: 0x00075154 File Offset: 0x00073354
		public new vtkGraph GetInput(int port)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0600509D RID: 20637
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDIMACSGraphWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600509E RID: 20638 RVA: 0x000751C4 File Offset: 0x000733C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600509F RID: 20639
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDIMACSGraphWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050A0 RID: 20640 RVA: 0x000751E4 File Offset: 0x000733E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060050A1 RID: 20641
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDIMACSGraphWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050A2 RID: 20642 RVA: 0x00075200 File Offset: 0x00073400
		public override int IsA(string type)
		{
			return vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060050A3 RID: 20643
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDIMACSGraphWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050A4 RID: 20644 RVA: 0x00075220 File Offset: 0x00073420
		public new static int IsTypeOf(string type)
		{
			return vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_IsTypeOf_06(type);
		}

		// Token: 0x060050A5 RID: 20645
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050A6 RID: 20646 RVA: 0x0007523C File Offset: 0x0007343C
		public new vtkDIMACSGraphWriter NewInstance()
		{
			vtkDIMACSGraphWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDIMACSGraphWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060050A7 RID: 20647
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDIMACSGraphWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050A8 RID: 20648 RVA: 0x00075298 File Offset: 0x00073498
		public new static vtkDIMACSGraphWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDIMACSGraphWriter vtkDIMACSGraphWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDIMACSGraphWriter.vtkDIMACSGraphWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDIMACSGraphWriter = (vtkDIMACSGraphWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDIMACSGraphWriter.Register(null);
				}
			}
			return vtkDIMACSGraphWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000799 RID: 1945
		public new const string MRFullTypeName = "Kitware.VTK.vtkDIMACSGraphWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079A RID: 1946
		public new static readonly string MRClassNameKey = "class vtkDIMACSGraphWriter";
	}
}
