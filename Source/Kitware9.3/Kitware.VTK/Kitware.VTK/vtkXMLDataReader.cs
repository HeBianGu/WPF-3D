using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for VTK XML file readers.
	///
	/// vtkXMLDataReader provides functionality common to all file readers for
	/// &lt;a href="http://www.vtk.org/Wiki/VTK_XML_Formats"&gt;VTK XML formats&lt;/a&gt;.
	/// Concrete subclasses call upon this functionality when needed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPDataReader
	/// </seealso>
	// Token: 0x020006C5 RID: 1733
	public abstract class vtkXMLDataReader : vtkXMLReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601276C RID: 75628 RVA: 0x0019DF77 File Offset: 0x0019C177
		static vtkXMLDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601276D RID: 75629 RVA: 0x0019DF9F File Offset: 0x0019C19F
		public vtkXMLDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601276E RID: 75630 RVA: 0x0019DFAD File Offset: 0x0019C1AD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601276F RID: 75631
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// Get the number of cells in the output.
		/// </summary>
		// Token: 0x06012770 RID: 75632 RVA: 0x0019DFB8 File Offset: 0x0019C1B8
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLDataReader.vtkXMLDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x06012771 RID: 75633
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataReader_GetNumberOfCells_02(HandleRef pThis);

		/// <summary>
		/// Get the number of cells in the output.
		/// </summary>
		// Token: 0x06012772 RID: 75634 RVA: 0x0019DFE8 File Offset: 0x0019C1E8
		public virtual long GetNumberOfCells()
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		// Token: 0x06012773 RID: 75635
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012774 RID: 75636 RVA: 0x0019E008 File Offset: 0x0019C208
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012775 RID: 75637
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012776 RID: 75638 RVA: 0x0019E028 File Offset: 0x0019C228
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012777 RID: 75639
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataReader_GetNumberOfPoints_05(HandleRef pThis);

		/// <summary>
		/// Get the number of points in the output.
		/// </summary>
		// Token: 0x06012778 RID: 75640 RVA: 0x0019E044 File Offset: 0x0019C244
		public virtual long GetNumberOfPoints()
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfPoints_05(base.GetCppThis());
		}

		// Token: 0x06012779 RID: 75641
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601277A RID: 75642 RVA: 0x0019E064 File Offset: 0x0019C264
		public override int IsA(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601277B RID: 75643
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601277C RID: 75644 RVA: 0x0019E084 File Offset: 0x0019C284
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_IsTypeOf_07(type);
		}

		// Token: 0x0601277D RID: 75645
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601277E RID: 75646 RVA: 0x0019E0A0 File Offset: 0x0019C2A0
		public new vtkXMLDataReader NewInstance()
		{
			vtkXMLDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataReader.vtkXMLDataReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601277F RID: 75647
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012780 RID: 75648 RVA: 0x0019E0FC File Offset: 0x0019C2FC
		public new static vtkXMLDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataReader vtkXMLDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataReader.vtkXMLDataReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataReader = (vtkXMLDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataReader.Register(null);
				}
			}
			return vtkXMLDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153B RID: 5435
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400153C RID: 5436
		public new static readonly string MRClassNameKey = "class vtkXMLDataReader";
	}
}
