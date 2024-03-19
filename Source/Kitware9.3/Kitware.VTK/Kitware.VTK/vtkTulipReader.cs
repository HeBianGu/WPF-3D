using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTulipReader
	/// </summary>
	/// <remarks>
	///    Reads tulip graph files.
	///
	///
	/// vtkTulipReader reads in files in the Tulip format.
	/// Definition of the Tulip file format can be found online at:
	/// http://tulip.labri.fr/tlpformat.php
	/// An example is the following
	/// &lt;code&gt;
	/// (nodes 0 1 2 3 4 5 6 7 8 9)
	/// (edge 0 0 1)
	/// (edge 1 1 2)
	/// (edge 2 2 3)
	/// (edge 3 3 4)
	/// (edge 4 4 5)
	/// (edge 5 5 6)
	/// (edge 6 6 7)
	/// (edge 7 7 8)
	/// (edge 8 8 9)
	/// (edge 9 9 0)
	/// (edge 10 0 5)
	/// (edge 11 2 7)
	/// (edge 12 4 9)
	/// &lt;/code&gt;
	/// where "nodes" defines all the nodes ids in the graph, and "edge"
	/// is a triple of edge id, source vertex id, and target vertex id.
	/// The graph is read in as undirected graph. Pedigree ids are set on the output
	/// graph's vertices and edges that match the node and edge ids defined in the
	/// Tulip file.
	///
	/// Clusters are output as a vtkAnnotationLayers on output port 1. Each cluster
	/// name is used to create an annotation layer, and each cluster with that name
	/// is added to the layer as a vtkSelectionNode. Nesting hierarchies are treated
	/// as if they were flat. See vtkGraphAnnotationLayersFilter for an example of
	/// how the clusters can be represented visually.
	///
	/// @attention
	/// Only string, int, and double properties are supported. Display information
	/// is discarded.
	///
	/// @par Thanks:
	/// Thanks to Colin Myers, University of Leeds for extending this implementation.
	/// </remarks>
	// Token: 0x020001A7 RID: 423
	public class vtkTulipReader : vtkUndirectedGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005226 RID: 21030 RVA: 0x00077B57 File Offset: 0x00075D57
		static vtkTulipReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTulipReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTulipReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005227 RID: 21031 RVA: 0x00077B7F File Offset: 0x00075D7F
		public vtkTulipReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005228 RID: 21032
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTulipReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005229 RID: 21033 RVA: 0x00077B90 File Offset: 0x00075D90
		public new static vtkTulipReader New()
		{
			vtkTulipReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTulipReader.vtkTulipReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600522A RID: 21034 RVA: 0x00077BE4 File Offset: 0x00075DE4
		public vtkTulipReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTulipReader.vtkTulipReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600522B RID: 21035 RVA: 0x00077C28 File Offset: 0x00075E28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600522C RID: 21036
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTulipReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The Tulip file name.
		/// </summary>
		// Token: 0x0600522D RID: 21037 RVA: 0x00077C34 File Offset: 0x00075E34
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTulipReader.vtkTulipReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600522E RID: 21038
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTulipReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600522F RID: 21039 RVA: 0x00077C70 File Offset: 0x00075E70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTulipReader.vtkTulipReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005230 RID: 21040
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTulipReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005231 RID: 21041 RVA: 0x00077C90 File Offset: 0x00075E90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTulipReader.vtkTulipReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005232 RID: 21042
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTulipReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005233 RID: 21043 RVA: 0x00077CAC File Offset: 0x00075EAC
		public override int IsA(string type)
		{
			return vtkTulipReader.vtkTulipReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005234 RID: 21044
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTulipReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005235 RID: 21045 RVA: 0x00077CCC File Offset: 0x00075ECC
		public new static int IsTypeOf(string type)
		{
			return vtkTulipReader.vtkTulipReader_IsTypeOf_05(type);
		}

		// Token: 0x06005236 RID: 21046
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTulipReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005237 RID: 21047 RVA: 0x00077CE8 File Offset: 0x00075EE8
		public new vtkTulipReader NewInstance()
		{
			vtkTulipReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTulipReader.vtkTulipReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005238 RID: 21048
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTulipReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005239 RID: 21049 RVA: 0x00077D44 File Offset: 0x00075F44
		public new static vtkTulipReader SafeDownCast(vtkObjectBase o)
		{
			vtkTulipReader vtkTulipReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTulipReader.vtkTulipReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTulipReader = (vtkTulipReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTulipReader.Register(null);
				}
			}
			return vtkTulipReader;
		}

		// Token: 0x0600523A RID: 21050
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTulipReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The Tulip file name.
		/// </summary>
		// Token: 0x0600523B RID: 21051 RVA: 0x00077DC3 File Offset: 0x00075FC3
		public virtual void SetFileName(string _arg)
		{
			vtkTulipReader.vtkTulipReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B3 RID: 1971
		public new const string MRFullTypeName = "Kitware.VTK.vtkTulipReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B4 RID: 1972
		public new static readonly string MRClassNameKey = "class vtkTulipReader";
	}
}
