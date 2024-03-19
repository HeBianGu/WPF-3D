using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRFlashParticlesReader
	/// </summary>
	/// <remarks>
	///    A concrete instance of vtkAMRBaseParticlesReader that implements
	///  functionality for reading flash particle datasets.
	/// </remarks>
	// Token: 0x0200022A RID: 554
	public class vtkAMRFlashParticlesReader : vtkAMRBaseParticlesReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060067F7 RID: 26615 RVA: 0x0009631F File Offset: 0x0009451F
		static vtkAMRFlashParticlesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRFlashParticlesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRFlashParticlesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060067F8 RID: 26616 RVA: 0x00096347 File Offset: 0x00094547
		public vtkAMRFlashParticlesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060067F9 RID: 26617
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashParticlesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067FA RID: 26618 RVA: 0x00096358 File Offset: 0x00094558
		public new static vtkAMRFlashParticlesReader New()
		{
			vtkAMRFlashParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRFlashParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067FB RID: 26619 RVA: 0x000963AC File Offset: 0x000945AC
		public vtkAMRFlashParticlesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060067FC RID: 26620 RVA: 0x000963F0 File Offset: 0x000945F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060067FD RID: 26621
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRFlashParticlesReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060067FE RID: 26622 RVA: 0x000963FC File Offset: 0x000945FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060067FF RID: 26623
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRFlashParticlesReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006800 RID: 26624 RVA: 0x0009641C File Offset: 0x0009461C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006801 RID: 26625
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashParticlesReader_GetTotalNumberOfParticles_03(HandleRef pThis);

		/// <summary>
		/// See vtkAMRBaseParticlesReader::GetTotalNumberOfParticles.
		/// </summary>
		// Token: 0x06006802 RID: 26626 RVA: 0x00096438 File Offset: 0x00094638
		public override int GetTotalNumberOfParticles()
		{
			return vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_GetTotalNumberOfParticles_03(base.GetCppThis());
		}

		// Token: 0x06006803 RID: 26627
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashParticlesReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006804 RID: 26628 RVA: 0x00096458 File Offset: 0x00094658
		public override int IsA(string type)
		{
			return vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06006805 RID: 26629
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRFlashParticlesReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006806 RID: 26630 RVA: 0x00096478 File Offset: 0x00094678
		public new static int IsTypeOf(string type)
		{
			return vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_IsTypeOf_05(type);
		}

		// Token: 0x06006807 RID: 26631
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashParticlesReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006808 RID: 26632 RVA: 0x00096494 File Offset: 0x00094694
		public new vtkAMRFlashParticlesReader NewInstance()
		{
			vtkAMRFlashParticlesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRFlashParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006809 RID: 26633
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRFlashParticlesReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600680A RID: 26634 RVA: 0x000964F0 File Offset: 0x000946F0
		public new static vtkAMRFlashParticlesReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMRFlashParticlesReader vtkAMRFlashParticlesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRFlashParticlesReader.vtkAMRFlashParticlesReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRFlashParticlesReader = (vtkAMRFlashParticlesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRFlashParticlesReader.Register(null);
				}
			}
			return vtkAMRFlashParticlesReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093B RID: 2363
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRFlashParticlesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400093C RID: 2364
		public new static readonly string MRClassNameKey = "class vtkAMRFlashParticlesReader";
	}
}
