using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractPolyDataReader
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that read
	/// models from a file.
	///
	/// This class allows to use a single base class to manage AbstractPolyData
	/// reader classes in a uniform manner without needing to know the actual
	/// type of the reader.
	/// i.e. makes it possible to create maps to associate filename extension
	/// and vtkAbstractPolyDataReader object.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOBJReader vtkPLYReader vtkSTLReader
	/// </seealso>
	// Token: 0x02000165 RID: 357
	public class vtkAbstractPolyDataReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004402 RID: 17410 RVA: 0x00063613 File Offset: 0x00061813
		static vtkAbstractPolyDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPolyDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004403 RID: 17411 RVA: 0x0006363B File Offset: 0x0006183B
		public vtkAbstractPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004404 RID: 17412 RVA: 0x00063649 File Offset: 0x00061849
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004405 RID: 17413
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolyDataReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify file name of AbstractPolyData file (obj / ply / stl).
		/// </summary>
		// Token: 0x06004406 RID: 17414 RVA: 0x00063654 File Offset: 0x00061854
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004407 RID: 17415
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPolyDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004408 RID: 17416 RVA: 0x00063690 File Offset: 0x00061890
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004409 RID: 17417
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPolyDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600440A RID: 17418 RVA: 0x000636B0 File Offset: 0x000618B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600440B RID: 17419
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolyDataReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600440C RID: 17420 RVA: 0x000636CC File Offset: 0x000618CC
		public override int IsA(string type)
		{
			return vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600440D RID: 17421
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPolyDataReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600440E RID: 17422 RVA: 0x000636EC File Offset: 0x000618EC
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_IsTypeOf_05(type);
		}

		// Token: 0x0600440F RID: 17423
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolyDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004410 RID: 17424 RVA: 0x00063708 File Offset: 0x00061908
		public new vtkAbstractPolyDataReader NewInstance()
		{
			vtkAbstractPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004411 RID: 17425
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPolyDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004412 RID: 17426 RVA: 0x00063764 File Offset: 0x00061964
		public new static vtkAbstractPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPolyDataReader vtkAbstractPolyDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPolyDataReader = (vtkAbstractPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPolyDataReader.Register(null);
				}
			}
			return vtkAbstractPolyDataReader;
		}

		// Token: 0x06004413 RID: 17427
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPolyDataReader_SetFileName_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of AbstractPolyData file (obj / ply / stl).
		/// </summary>
		// Token: 0x06004414 RID: 17428 RVA: 0x000637E3 File Offset: 0x000619E3
		public virtual void SetFileName(string _arg)
		{
			vtkAbstractPolyDataReader.vtkAbstractPolyDataReader_SetFileName_08(base.GetCppThis(), _arg);

        }

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000711 RID: 1809
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPolyDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000712 RID: 1810
		public new static readonly string MRClassNameKey = "class vtkAbstractPolyDataReader";
	}
}
